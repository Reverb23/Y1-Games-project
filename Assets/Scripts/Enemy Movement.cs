using System;
using UnityEngine;

public class EnemyFollowing : MonoBehaviour
{
    private int Damage = 5;
    [SerializeField]
    private float Speed = 1.5f;
    private float Health = 15.0f;
    GameObject PlayerObject;
    Vector2 PlayerPos =>PlayerObject.transform.position;

    private Rigidbody2D rb;


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
            print("enemy hit");


        }
    }
}
