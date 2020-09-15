//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public interface IWeapon
{
    bool IsShooting { get; set; }
    void Shoot();
}
