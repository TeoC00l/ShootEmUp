//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;

public abstract class Health : MonoBehaviour
{
    [SerializeField] private int maxHitPoints = 10;
    protected IDeathBehaviour deathBehaviour;
    
    public int CurrentHitPoints { get; set; }

    private void OnEnable()
    {
        Assert.IsNotNull(deathBehaviour);
        CurrentHitPoints = maxHitPoints;
    }
    
    public void Die()
    {
        deathBehaviour.Die();
    }
    
    public void LowerHitPoints(int damage)
    {
        CurrentHitPoints -= damage;
        
        if(CurrentHitPoints <= 0)
        {
            Die();
        }
    }
}