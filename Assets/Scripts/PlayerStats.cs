using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int PlayerHealth = 100; //needs to be externally modified
    [SerializeField]
    private int PlayerLevel = 1; //real value of player level and the one to be modified
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnCollisionEnter2D(Collision2D collision) 
    // {
    //     Debug.Log("colission detected");
    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {

    //         Debug.Log("goon");
    //         PlayerHealth -= 10;
                
    //     }
    
     
    
    // }
    public void PlayerAttacks(Vector2 PlayerPos) //called whenever the player attacsk
    { 
        //player level = amount of projectiles, inc every 5
        //wrrk out angle from 360/proj -- Done
        //level up by killing'WIP


        for (int i = 0; i<PlayerProjAmount; i++) //spawn correct amount of projectiles
        {
            GameObject NewProjectile = Instantiate(PlayerProjectile, new Vector3(PlayerPos.x+(float)(ProjectileRadius*Math.Cos(ProjectileAngle)) ,PlayerPos.y+(float)(ProjectileRadius*Math.Sin(ProjectileAngle)), 0),Quaternion.identity);
            ProjectileAngle += (float)(2*Math.PI)/ProjectileAmount; //Math.x uses radians not degrees
            print(ProjectileAngle);
            // Projectilerb.AddForce((Vector2)Projectilerb.transform.position* ProjectileForce, ForceMode2D.Force);
            // Projectilerb.linearVelocity = (Vector2)Projectilerb.transform.position-PlayerPos*ProjectileForce;
            // Projectilerb.MovePosition(Projectilerb + ProjectileForce*Time.deltaTime);
            // ProjectileDirection = new Vector2(Mathf.Cos(ProjectileAngle), Mathf.Sin(ProjectileAngle));
            // Projectilerb.linearVelocity = ProjectileDirection * ProjectileForce;
            Rigidbody2D Projectilerb = NewProjectile.GetComponent<Rigidbody2D>();
            // Projectilerb.AddForce((Vector2)Projectilerb.transform.position+(Vector2)PlayerObject.transform.position* ProjectileForce, ForceMode2D.Force);
            // ProjectileDirection = new Vector2((float)Math.Cos(ProjectileAngle), (float)Math.Sin(ProjectileAngle));
            // Projectilerb.linearVelocity = ProjectileDirection * ProjectileForce;
            ProjectileDirection = new Vector2(Projectilerb.position.x-PlayerPos.x,Projectilerb.position.y-PlayerPos.y).normalized;
            Projectilerb.linearVelocity = ProjectileDirection * ProjectileForce;
            print(PlayerObject.transform.position);
            print("ForceMode applied");
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

}
