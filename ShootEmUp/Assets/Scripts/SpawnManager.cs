//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(SpawnChanceSliders))]
public class SpawnManager : MonoBehaviour
{
    public const int NO_OF_TABLE_INDEXES = 100;
    
    public GameObject[] spawnObjects = default;
    private Dictionary<int, GameObject> spawnObjectTable;
    private SpawnChanceSliders spawnChanceSliders;

    private Transform[] spawnPositions;
    
    private float minSpawnTime = 0.05f;
    private float maxSpawnTime = 0.5f;
    private float timer = default;

    //TODO: refactor Awake()
    private void Awake()
    {
        spawnChanceSliders = GetComponent<SpawnChanceSliders>();
        
        foreach (GameObject spawnObject in spawnObjects)
        {
            PoolManager.Instance.CreatePool(spawnObject, 100);
        }

        if (spawnObjects.Length % 2 != 0)
        {
            GameObject[] newSpawnObjects = new GameObject[spawnObjects.Length + 1];

            for (int i = 0; i < spawnObjects.Length; i++)
            {
                newSpawnObjects[i] = spawnObjects[i];
            }

            newSpawnObjects[spawnObjects.Length - 1] = spawnObjects[0];
            spawnObjects = newSpawnObjects;
        }
        
        int noOfElement = spawnObjects.Length;
        int spawnPercentChance = NO_OF_TABLE_INDEXES / spawnObjects.Length;

        spawnObjectTable = new Dictionary<int, GameObject>();

        int currentIndex = 0;
        
        
        for (int i = 0; i < spawnObjects.Length; i++)
        {
            int indexSpawnPercentageChance = spawnChanceSliders.sliderValues[i];
            
            for (int j = 0; j <= indexSpawnPercentageChance; j++)
            {
                spawnObjectTable.Add(currentIndex, spawnObjects[i]);
                currentIndex++;
            }
        }
  
        spawnPositions = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        
        SpawnEnemy();

    }

    private void SpawnEnemy()
    {
        if (timer > 0)
        {
            return;
        }

        GameObject spawnPrefab = spawnObjectTable[Random.Range(0, NO_OF_TABLE_INDEXES)];
        
        Vector2 transformPosition = spawnPositions[Random.Range(0, spawnPositions.Length)].position;
        PoolManager.Instance.ReuseObject(spawnPrefab, transformPosition, quaternion.identity);
            
        timer = Random.Range(minSpawnTime, maxSpawnTime);
    }
    
}
