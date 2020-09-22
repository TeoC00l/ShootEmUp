//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public interface IHealthComponent
{
    void LowerHitPoints(int damage);
    void Die();
    
}
