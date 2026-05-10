using System.Collections;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{


    public GameObject EnemyPrototype;
    [SerializeField]
    private PlayerStats PlayerStatsReference;
    [SerializeField]
    private int SpawnInterval = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       StartCoroutine(Spawning(EnemyPrototype));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawning(GameObject EnemyPrototype)
    {
        if (PlayerStatsReference.PlayerAlive == true)
        {
            GameObject NewEnemy = Instantiate(EnemyPrototype, new Vector3(0,0,0), Quaternion.identity);
            yield return new WaitForSeconds(SpawnInterval);
            StartCoroutine(Spawning(EnemyPrototype));
        }


    }
}
