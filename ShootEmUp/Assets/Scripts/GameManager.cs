//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using System;

[DefaultExecutionOrder(-100)]
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

    [NonSerialized] public GameObject player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerHealth>().gameObject;
    }
}
