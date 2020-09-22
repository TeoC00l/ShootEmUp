//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

[RequireComponent(typeof(EnemyHealth))]
[RequireComponent(typeof(SineEnemyMovement))]
public class SineEnemyBehaviour: EnemyBehaviour
{
    private void Awake()
    {
        health = GetComponent<EnemyHealth>();
        gameObject.tag = "Damageable";
    }
}
