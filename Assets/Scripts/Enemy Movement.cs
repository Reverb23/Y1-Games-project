using System;
using UnityEngine;

public class EnemyFollowing : MonoBehaviour
{
    public static int Damage = 5;
    [SerializeField]
    public static float Speed = 3;
    public static int MaxHealth = 15;
    public  int Health = 15;
    GameObject PlayerObject;
    Vector2 PlayerPos =>PlayerObject.transform.position;

    private Rigidbody2D rb;
    public PlayerStats PlayerStatsReference => PlayerStats.instance;
    private GameObject ThisEnemy;
    public EnemyHealthBar EnemyHealthBarReference;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        Health = MaxHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveToPlayer();

    }

    void MoveToPlayer()
    {
        Vector2 DistanceToPlayer = PlayerPos - (Vector2)transform.position;
        rb.linearVelocity = Speed * (Vector3)DistanceToPlayer.normalized;

    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("PlayerProjectile"))
        {
            Health -= (int)PlayerStatsReference.PlayerDamage;
            Destroy(collision.gameObject);
            EnemyHealthBarReference.SetHealthOnChange();
            if (Health < 0)
            {
                PlayerStatsReference.OnEnemyKill();
                print("kill");
                Destroy(gameObject);
                
            }


        }
    }
}
