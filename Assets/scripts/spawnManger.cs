using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManger : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    float SpawnRangeX = 20;
    float spawnPosZ = 35;
    public float startingSpawn = 5; 
    public float spawnTiming = 1.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomItem", startingSpawn, spawnTiming);
    }

    void SpawnRandomItem()

    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, spawnPosZ); 
            
            int itemIndex = Random.Range(0, itemPrefabs.Length); 
            
            Instantiate(itemPrefabs[itemIndex], spawnPos, itemPrefabs[itemIndex].transform.rotation);

    }
}
