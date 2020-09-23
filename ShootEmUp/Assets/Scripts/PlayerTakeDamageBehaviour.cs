//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;

public class PlayerTakeDamageBehaviour : ITakeDamageBehaviour
{
    private Shield shield;
    private Health health;

    public PlayerTakeDamageBehaviour(Shield shield, Health health)
    {
        this.health = health;
        this.shield = shield;
    }

    public void TakeDamage(int damage)
    {
        if (shield.isActive)
        {
            shield.takeDamage(damage);
            return;
        }

        health.CurrentHitPoints -= damage;

        if (health.CurrentHitPoints <= 0)
        {
            health.Die();
        }
        
    }
}    
