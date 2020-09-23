//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;

public abstract class Health : MonoBehaviour
{
    protected IDeathBehaviour deathBehaviour;
    protected ITakeDamageBehaviour takeDamageBehaviour;
    
    [SerializeField] private int maxHitPoints = 10;
    
    public int CurrentHitPoints { get; set; }

    private void Awake()
    {
        Initialize();
        
        Assert.IsNotNull(deathBehaviour);
        Assert.IsNotNull(takeDamageBehaviour);
    }
    
    private void OnEnable()
    {
        CurrentHitPoints = maxHitPoints;
    }
    
    public void Die()
    {
        deathBehaviour.Die();
    }
    
    public void TakeDamage(int damage)
    {
        takeDamageBehaviour.TakeDamage(damage);
    }

    //Set Behaviours In this rather than Awake()
    protected abstract void Initialize();
}