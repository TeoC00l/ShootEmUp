//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
[RequireComponent(typeof(SineEnemyMovement))]
public class SineEnemy: Enemy
{
    protected override void Initialize()
    {
        health = GetComponent<EnemyHealth>();
        movement = GetComponent<SineEnemyMovement>();
    }
}
