using System.Collections;
using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{


    public GameObject EnemyPrototype;
    [SerializeField]
    private PlayerStats PlayerStatsReference;
    [SerializeField]
    private int SpawnInterval = 1;
    [SerializeField]
    GameObject PlayerObject;

    Vector2 PlayerPos =>PlayerObject.transform.position;
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
            
            GameObject NewEnemy = Instantiate(EnemyPrototype, new Vector3(PlayerPos.x+Random.Range(-SpawnDist,SpawnDist) ,PlayerPos.y+Random.Range(-5f,5),0), Quaternion.identity);
            yield return new WaitForSeconds(SpawnInterval);
            PlayerPos = PlayerObject.transform.position;
            StartCoroutine(Spawning(EnemyPrototype, PlayerPos, PlayerObject, SpawnDist));
            print(PlayerPos);
        }


    }
}
