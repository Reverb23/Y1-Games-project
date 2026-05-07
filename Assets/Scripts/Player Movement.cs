using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D rb;
    [SerializeField] private float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = InputManaging.instance.InputAxis * Speed;
    }
}
