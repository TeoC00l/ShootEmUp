//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

[RequireComponent(typeof(EnemyDeathBehaviour))]
public class EnemyHealth : Health
{
    private void Awake()
    {
        deathBehaviour = GetComponent<EnemyDeathBehaviour>();
    }
}
