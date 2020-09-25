//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine.Assertions;

public class PlayerHealth : Health
{
    protected override void Initialize()
    {
        Shield shield = GetComponent<Shield>();
        Assert.IsNotNull(shield, "player does not have a shield component!");
        
        deathBehaviour = new PlayerDeathBehaviour(gameObject);
        takeDamageBehaviour = new PlayerTakeDamageBehaviour(shield, this);
    }
}
