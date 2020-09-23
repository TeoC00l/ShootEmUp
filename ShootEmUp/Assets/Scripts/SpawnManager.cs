//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    private float minSpawnTime = 0.05f;
    private float maxSpawnTime = 0.5f;
    private float timer = default;
    
    private Transform[] spawnPositions;
    [SerializeField] private GameObject[] spawnObjects = default;
    
    private void Awake()
    {
        foreach (GameObject spawnObject in spawnObjects)
        {
            PoolManager.Instance.CreatePool(spawnObject, 100);
        }
        
        spawnPositions = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0f)
        {
            GameObject spawnPrefab = spawnObjects[Random.Range(0, spawnObjects.Length)];
            Vector2 transformPosition = spawnPositions[Random.Range(0, spawnPositions.Length)].position;
            PoolManager.Instance.ReuseObject(spawnPrefab, transformPosition, quaternion.identity);
            
            timer = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
