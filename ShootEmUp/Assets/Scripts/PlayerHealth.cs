//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Initialize()
    {
        deathBehaviour = new PlayerDeathBehaviour(gameObject);
        takeDamageBehaviour = new PlayerTakeDamageBehaviour(GetComponent<Shield>(), this);
        
        
        
    }
}
