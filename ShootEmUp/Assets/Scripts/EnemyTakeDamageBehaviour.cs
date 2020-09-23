//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class EnemyTakeDamageBehaviour : ITakeDamageBehaviour
{
    private Health health;
        
    public EnemyTakeDamageBehaviour(Health health)
    {
        this.health = health;
    }
    
    public void TakeDamage(int damage)
    {
        health.CurrentHitPoints -= damage;

        if (health.CurrentHitPoints <= 0)
        {
            health.Die();
        }
    }
}
