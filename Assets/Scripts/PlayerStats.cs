using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int PlayerHealth = 100; //needs to be externally modified
    [SerializeField]
    private int PlayerLevel = 1; //real value of player level and the one to be modified
    private float ProjectileAngle = 120f; 
    private int ProjectileAmount = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    public void PlayerAttacks() //called whenever the player attacsk
    { 
        //player level = amount of projectiles, inc every 5
        //wrrk out angle from 360/proj
        //level up by killing'WIP

    }

}
