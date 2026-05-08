using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int PlayerHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("munt");
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Debug.Log("goon");
            PlayerHealth -= 10;
                
        }
    
    
    
    }

}
