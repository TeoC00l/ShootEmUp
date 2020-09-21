//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    private float minSpawnTime = 0.05f;
    private float maxSpawnTime = 0.5f;
    private float timer = default;
    
    private Transform[] spawnPositions;
    [SerializeField] private GameObject[] spawnObjects;
    private void Awake()
    {
        spawnPositions = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0f)
        {
            GameObject go = Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)]);
            go.transform.position = spawnPositions[Random.Range(0, spawnPositions.Length)].transform.position;
            timer = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
