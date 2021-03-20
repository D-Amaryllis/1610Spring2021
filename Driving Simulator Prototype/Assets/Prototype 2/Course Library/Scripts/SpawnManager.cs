using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float SpawnInterval = 1.5f;
    public float StartDelay = 2;
    
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            
        Instantiate(animalPrefabs[animalIndex],spawnPos, 
            animalPrefabs[animalIndex].transform.rotation);
    }
}
