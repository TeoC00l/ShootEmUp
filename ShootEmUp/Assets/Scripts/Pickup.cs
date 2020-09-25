//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Pickup : MonoBehaviour
{
    [SerializeField]private GameObject pickup;

    private void OnTriggerEnter2D(Collider2D other)
    {
    }
}
