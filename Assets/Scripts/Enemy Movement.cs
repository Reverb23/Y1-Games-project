using System;
using UnityEngine;

public class EnemyFollowing : MonoBehaviour
{
    public int Damage = 5;
    [SerializeField]
    public float Speed = 3f;
    private float Health = 15.0f;
    GameObject PlayerObject;
    Vector2 PlayerPos =>PlayerObject.transform.position;

    private Rigidbody2D rb;
    public PlayerStats PlayerStatsReference => PlayerStats.instance;
    private GameObject ThisEnemy;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
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
        print(collision);
        if (collision.gameObject.CompareTag("PlayerProjectile"))
        {
            Health -= PlayerStatsReference.PlayerDamage;
            if (Health <= 0)
            {
                Destroy(gameObject);
            }


        }
    }
}
