//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

public class PlayerTakeDamageBehaviour : ITakeDamageBehaviour
{
    private readonly Shield shield;
    private readonly Health health;

    public PlayerTakeDamageBehaviour(Shield shield, Health health)
    {
        this.health = health;
        this.shield = shield;
    }

    public void TakeDamage(int damage)
    {
        if (shield.isActive)
        {
            shield.TakeDamage(damage);
            return;
        }

        health.CurrentHitPoints -= damage;

        if (health.CurrentHitPoints <= 0)
        {
            health.Die();
        }
        
    }
}    
