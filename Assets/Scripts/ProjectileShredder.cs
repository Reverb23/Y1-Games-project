using UnityEngine;

public class ProjectileShredder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject PlayerObject;
    GameObject Shredder;
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        Shredder = GameObject.FindWithTag("Shredder");
        print("shredder active");

    }

    // Update is called once per frame
    void Update()
    {
        
        Shredder.transform.position = PlayerObject.transform.position;

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("PlayerProjectile"))
        {
            
            Destroy(other.gameObject);

        }
    }
}
