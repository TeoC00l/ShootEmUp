//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public abstract class EnemyBehaviour: MonoBehaviour
{
    protected IEnemyMovement movement;
    protected EnemyHealth health;
    private Transform enemyTransform;
    
    [SerializeField] private int onHitDamage = 2;
    [SerializeField] private float despawnDistance = 30f;

    private void Start()
    {
        enemyTransform = transform;
    }
    
    
    private void Update()
    {
        float distanceFromCenter = Vector2.Distance(Vector2.zero, enemyTransform.position);
        
        if (distanceFromCenter >= despawnDistance)
        {
            health.Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Health>().LowerHitPoints(onHitDamage);
            health.Die();
        }
    }

}
