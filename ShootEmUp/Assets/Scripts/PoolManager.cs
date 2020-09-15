﻿//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Assertions;

public class PoolManager : MonoBehaviour
{
    private static PoolManager instance;

    public static PoolManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PoolManager>();
            }

            return instance;
        }
    }
    
    private Dictionary<int, Queue<GameObject>> poolDictionary = new Dictionary<int, Queue<GameObject>>();
    
    public void CreatePool(GameObject prefab, int poolSize)
    {
        int poolKey = prefab.GetInstanceID();
        
        Assert.IsFalse(poolDictionary.ContainsKey((poolKey)));

        poolDictionary.Add(poolKey, new Queue<GameObject>());

        for (int i = 0; i < poolSize; i++)
        {
            GameObject newObject = Instantiate(prefab) as GameObject;
            newObject.SetActive(false);
            poolDictionary[poolKey].Enqueue(newObject);
        }
    }

    public void ReuseObject(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        int poolKey = prefab.GetInstanceID();

        if (!poolDictionary.ContainsKey(poolKey))
        {
            return;
        }
        
        GameObject gameObjectToReuse = poolDictionary[poolKey].Dequeue();
        poolDictionary[poolKey].Enqueue(gameObjectToReuse);
            
        gameObjectToReuse.SetActive(true);
        gameObjectToReuse.transform.position = position;
        gameObjectToReuse.transform.rotation = rotation;
    }
}