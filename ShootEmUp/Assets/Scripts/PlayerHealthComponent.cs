//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class PlayerHealthComponent : MonoBehaviour, IHealthComponent
{
    public static PlayerHealthComponent instance;
    private int defaultHitPoints = 10;
    private AudioClip onDeathSound;

    public int CurrentHitPoints { get; set; }

    
    private void Awake()
    {
        instance = this;
        CurrentHitPoints = defaultHitPoints;
    }
    
    public void LowerHitPoints(int damage)
    {
        Debug.Log(CurrentHitPoints);
        CurrentHitPoints -= damage;
        Debug.Log(CurrentHitPoints);
        
        if(CurrentHitPoints <= 0)
        {
            Die();
        }
    }
    
    public void Die()
    {
        if (onDeathSound != null)
        {
            AudioSource.PlayClipAtPoint(onDeathSound, transform.position);
        }
        Destroy(gameObject);
    }
}
