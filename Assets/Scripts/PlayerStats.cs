using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int PlayerHealth = 100; //needs to be externally modified
    private int _PlayerLevel = 1; //real value of player level and the one to be modified
    public static int PlayerLevel //global and un-modifiable/read only version of playerlevel
    {  
        get { return _PlayerLevel; }
    }
    


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
        Debug.Log("colission detected");
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Debug.Log("goon");
            PlayerHealth -= 10;
                
        }
    
     
    
    }

}
