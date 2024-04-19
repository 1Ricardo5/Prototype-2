using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
   private float spawnRangeX = 20;
   private float spawnPosZ = 20;
   private float startDelay = 2;
   private float spawnInterval = 0.5f;
   private float spawnPosX = 20;
   private float spawnRangeZ = 20;
   
    // Start is called before the first frame update
   
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
     {
      
     }
     
     
     void SpawnAnimal()
     {
      int Spawn = Random.Range(1, 4);
      if (Spawn == 1)
      {
        SpawnRandomAnimal();
      }

      if (Spawn == 2)
      {
        SpawnLeftAnimal();
      }

      if (Spawn == 3)
      {
        SpawnRightAnimal();
      }
     }
      
     

      void SpawnRandomAnimal() 
      {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        
      }  
      void SpawnLeftAnimal()
      {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,-90,0));
      }

      void SpawnRightAnimal()
      {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,90,0 ));
      }

     

 }
