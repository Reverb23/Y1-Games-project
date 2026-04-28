using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int Damage = 5;
    private float Speed = 1.5f;
    private float Health = 50.0f;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();

    }

    void MoveToPlayer()
    {
        Vector3 PlayerPos = GameObject.FindWithTag("Player").transform.position;
        transform.position = transform.position + (PlayerPos*Speed*Time.deltaTime);
        Debug.Log(PlayerPos);
    }
}
