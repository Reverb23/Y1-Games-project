using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float PlayerMaxHealth = 100f;
    public float PlayerHealth = 100f; //needs to be externally modified
    [SerializeField]
    public int PlayerLevel = 2; //real value of player level and the one to be modified
    public float PlayerDamage = 5;
    private float ProjectileAngle = 0f; 
    private int ProjectileAmount = 3;
    public bool PlayerAlive = true;
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
    public EnemyFollowing EnemyFollowingReference;
    public int KillCount = 0;
    public int LevelUpKills = 15;
    public EnemySpawning EnemySpawningReference;
    public PlayerHealthBar PlayerHealthBarReference;
    public EnemyHealthBar EnemyHealthBarReference;
    public UpdateKillLabel UpdateKillLabelReference;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        
        instance = this;
    }
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        print(PlayerStats.instance);
        UpdateKillLabelReference.UpdateKillCount();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerHealth -= EnemyFollowing.Damage;
            PlayerHealthBarReference.SetHealthOnChange();
            
        }
    
        if (PlayerHealth <= 0)
        {
            Debug.Log("death");
            
        }
    
    }
    public void PlayerAttacks(Vector2 PlayerPos) //called whenever the player attacsk
    { 
        //player level = amount of projectiles, inc every 5
        //wrrk out angle from 360/proj -- Done
        //level up by killing'WIP


        for (int i = 0; i<ProjectileAmount+1; i++) //spawn correct amount of projectiles
        {
            GameObject NewProjectile = Instantiate(PlayerProjectile, new Vector3(PlayerPos.x+(float)(ProjectileRadius*Math.Cos(ProjectileAngle)) ,PlayerPos.y+(float)(ProjectileRadius*Math.Sin(ProjectileAngle)), 0),Quaternion.identity);
            ProjectileAngle += (float)(2*Math.PI)/ProjectileAmount; //Math.x uses radians not degrees
            Rigidbody2D Projectilerb = NewProjectile.GetComponent<Rigidbody2D>(); //has tyo be here as it is a new rb every time
            ProjectileDirection = new Vector2(Projectilerb.position.x-PlayerPos.x,Projectilerb.position.y-PlayerPos.y).normalized;
            Projectilerb.linearVelocity = ProjectileDirection * ProjectileForce;
            
            
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
    public void PlayerLevelUp()
    {
        float PlayerMult = 1.8f;
        float EnemyMult = 1.4f;
        PlayerLevel++;
        print("LEVEL UP");
        LevelUpKills = (int)(1.3f * LevelUpKills);
        if (PlayerLevel > 1)
        {
            PlayerMaxHealth *= PlayerMult * ((float)Math.Log10(2*(PlayerLevel)));
            PlayerHealth *= PlayerMult * ((float)Math.Log10(2*(PlayerLevel)));
            PlayerDamage *= PlayerMult * ((float)Math.Log10(2 * (PlayerLevel)));
            print(PlayerHealth);
            EnemyFollowing.MaxHealth = (int)((EnemyMult*1.3) * EnemyFollowing.MaxHealth);
            EnemyFollowing.Damage = (int)((EnemyMult*1.5) * EnemyFollowing.Damage);
            EnemyFollowing.Speed = (int)(EnemyMult * EnemyFollowing.Speed);
            EnemySpawningReference.SpawnInterval = (0.99f*EnemySpawningReference.SpawnInterval);
            if (PlayerLevel % 3 == 0)
            {
                ProjectileAmount++;
                
            }

        }
        //print(LevelUpKills);
        KillCount = 0;
        PlayerHealthBarReference.SetHealthOnLevelUp();
        EnemyHealthBarReference.SetHealthOnLevelUp();
    }
    public void OnEnemyKill()
    {
        KillCount++;
        UpdateKillLabelReference.UpdateKillCount();
        if (KillCount >= LevelUpKills)
        {
            PlayerLevelUp();
        
        }

    }
}

//TODO make UI, HEalthbars, menus, player dying, timers
