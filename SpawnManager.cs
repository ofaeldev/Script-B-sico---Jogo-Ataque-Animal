using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    int spawnRangeX = 20;
    int spawnPosZ = 20;
    float startDelay = 2;
    float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);    
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalsPrefab.Length);
        Instantiate(animalsPrefab[animalIndex], spawnPos,
            animalsPrefab[animalIndex].transform.rotation);
    }
}
