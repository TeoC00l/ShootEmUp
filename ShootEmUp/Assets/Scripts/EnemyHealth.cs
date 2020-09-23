//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Initialize()
    {
        deathBehaviour = new EnemyDeathBehaviour(gameObject);
        takeDamageBehaviour = new EnemyTakeDamageBehaviour(this);
    }
}
