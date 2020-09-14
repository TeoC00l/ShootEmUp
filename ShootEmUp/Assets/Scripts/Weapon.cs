//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class Weapon : MonoBehaviour
{
    private IWeapon currentWeapon;

    private void Awake()
    {
        currentWeapon = GetComponentInChildren<Blaster>();
    }

    private void OnShoot()
    {
        currentWeapon.Shoot();
    }
}
