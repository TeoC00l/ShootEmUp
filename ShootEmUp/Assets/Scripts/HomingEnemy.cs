//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

[RequireComponent(typeof(EnemyHealth))]
[RequireComponent(typeof(HomingEnemyMovement))]
[RequireComponent((typeof(Rigidbody2D)))]

public class HomingEnemy : Enemy
{
    protected override void Initialize()
    {
        health = GetComponent<EnemyHealth>();
        movement = GetComponent<HomingEnemyMovement>();
    }
}