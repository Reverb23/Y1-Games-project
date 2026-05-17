using System.Collections;
using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{


    public GameObject EnemyPrototype;
    [SerializeField]
    private PlayerStats PlayerStatsReference;
    [SerializeField]
    public float SpawnInterval = 2;
    [SerializeField]
    GameObject PlayerObject;

    public Vector2 PlayerPos =>PlayerObject.transform.position;
    [SerializeField]
    private float SpawnDist = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        StartCoroutine(Spawning(EnemyPrototype, PlayerPos, PlayerObject, SpawnDist));
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    IEnumerator Spawning(GameObject EnemyPrototype, Vector2 PlayerPos, GameObject PlayerObject, float SpawnDist)
    {
        if (PlayerStatsReference.PlayerAlive == true)
        {
            for (int i = 0; i<PlayerStatsReference.PlayerLevel*0.1; i++)
            {
                
            
                GameObject NewEnemy = Instantiate(EnemyPrototype, new Vector3(PlayerPos.x+Random.Range(-PlayerPos.x-SpawnDist,PlayerPos.x+SpawnDist) ,PlayerPos.y+Random.Range(-PlayerPos.y-SpawnDist,PlayerPos.y+SpawnDist),0), Quaternion.identity);
                yield return new WaitForSeconds(SpawnInterval);
                PlayerPos = PlayerObject.transform.position;
                StartCoroutine(Spawning(EnemyPrototype, PlayerPos, PlayerObject, SpawnDist));
            }
        }


    }
}
