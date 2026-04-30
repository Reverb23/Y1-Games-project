using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int Damage = 5;
    private float Speed = 1.5f;
    private float Health = 50.0f;
    GameObject PlayerObject;
    Vector2 PlayerPos =>PlayerObject.transform.position;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();

    }

    void MoveToPlayer()
    {
        Vector2 DistanceToPlayer = PlayerPos - (Vector2)transform.position;
        transform.position += Speed * Time.deltaTime * (Vector3)DistanceToPlayer.normalized;
        //(Vector2)transform.position + (Speed * Time.deltaTime * PlayerPos);
        Debug.Log(PlayerPos);
    }
}
