//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

[RequireComponent(typeof(PlayerDeathBehaviour))]
public class PlayerHealth : Health
{
    private void Awake()
    {
        deathBehaviour = GetComponent<PlayerDeathBehaviour>();
    }
}
