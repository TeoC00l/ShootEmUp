//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;

public abstract class Enemy: MonoBehaviour
{
    protected IEnemyMovement movement;
    protected EnemyHealth health;
    private Transform enemyTransform;
    
    [SerializeField] private int onHitDamage = 2;
    [SerializeField] private float despawnDistance = 30f;

    private void Awake()
    {
        gameObject.tag = "Damageable";
        enemyTransform = transform;
        
        Initialize();
        
        Assert.IsNotNull(movement);
        Assert.IsNotNull(health);
    }
    
    
    private void Update()
    {
        movement.Move();
        CheckForDespawn();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Health>().TakeDamage(onHitDamage);
            health.Die();
        }
    }

    protected void CheckForDespawn()
    {
        float distanceFromCenter = Vector2.Distance(Vector2.zero, enemyTransform.position);
        
        if (distanceFromCenter >= despawnDistance)
        {
            health.Die();
        }
    }

    protected abstract void Initialize();

}
