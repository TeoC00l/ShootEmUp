//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }

            return instance;
        }
    }
    
    [NonSerialized] public PlayerHealth playerHealth;
    [NonSerialized] public Transform playerTransform;
    [NonSerialized] public Vector2 playerPosition;
    
    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        playerPosition = playerTransform.position;
    }
}
