using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int Damage = 5;
    private float Speed = 1.5f;
    private float Health = 50.0f;
    private EnemyStats data;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Chase();

    }
    private void Chase()
    {


        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Speed*Time.deltaTime);
    }
}
