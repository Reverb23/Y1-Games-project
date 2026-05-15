using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float PlayerHealth = 100f; //needs to be externally modified
    [SerializeField]
    private int PlayerLevel = 1; //real value of player level and the one to be modified
    public int PlayerDamage = 5;
    private float ProjectileAngle = 0f; 
    private int ProjectileAmount = 3;
    public bool PlayerAlive = true;
    private float PlayerProjAmount = 3;
    public GameObject PlayerProjectile;
    public GameObject PlayerObject;
    [SerializeField]
    private int ProjectileRadius = 3;
    [SerializeField]
    private float ProjectileForce = 150f;
    [SerializeField]
    public Rigidbody2D Projectilerb; // get rigidbody for applying force away from player
    private Vector2 ProjectileDirection;
    public static PlayerStats instance;
    public EnemyFollowing EnemyFollowingingReference;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("colission detected");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerHealth -= 10;              
        }
    
        if (PlayerHealth <= 0)
        {
            Debug.Log("death");
            ;
        }
    
    }
    public void PlayerAttacks(Vector2 PlayerPos) //called whenever the player attacsk
    { 
        //player level = amount of projectiles, inc every 5
        //wrrk out angle from 360/proj -- Done
        //level up by killing'WIP


        for (int i = 0; i<PlayerProjAmount; i++) //spawn correct amount of projectiles
        {
            GameObject NewProjectile = Instantiate(PlayerProjectile, new Vector3(PlayerPos.x+(float)(ProjectileRadius*Math.Cos(ProjectileAngle)) ,PlayerPos.y+(float)(ProjectileRadius*Math.Sin(ProjectileAngle)), 0),Quaternion.identity);
            ProjectileAngle += (float)(2*Math.PI)/ProjectileAmount; //Math.x uses radians not degrees
            Rigidbody2D Projectilerb = NewProjectile.GetComponent<Rigidbody2D>(); //has tyo be here as it is a new rb every time
            ProjectileDirection = new Vector2(Projectilerb.position.x-PlayerPos.x,Projectilerb.position.y-PlayerPos.y).normalized;
            Projectilerb.linearVelocity = ProjectileDirection * ProjectileForce;
            PlayerLevelUp(PlayerHealth, PlayerLevel, PlayerDamage);
            
        }
        
        ProjectileAngle = 0;





                    //Move to PlayerLevel Function
        // if (PlayerLevel < 6)
        // {
        //     PlayerProjAmount = 3;
        // }
        // else
        // {
        //     int PlayerProjAmount = (int)Math.Floor((double)PlayerLevel/5);
        //     print(PlayerProjAmount);
        // }

    }
    public void PlayerLevelUp(float PlayerHealth, int PlayerLevel, int PlayerDamage)
    {
        float PlayerMult = 3.0f;
        float EnemyMult = 1.2f;
        PlayerHealth = PlayerMult *(float)Math.Log10(PlayerHealth);
        
        EnemyFollowingingReference.Damage **= 1.2;


    }
}
