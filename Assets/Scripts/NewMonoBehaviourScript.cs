using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Collect players position at current time(every frame)
       Vector2 position = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x = position.x + 0.1f;
        }
    }
}
