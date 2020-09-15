//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    private IWeapon currentWeapon;
    private bool isShooting;

    private void Awake()
    {
        currentWeapon = GetComponentInChildren<Blaster>();
    }

    private void OnShoot(InputValue value)
    {
        isShooting = value.isPressed;
    }

    private void Update()
    {
        if (isShooting)
        {
            currentWeapon.Shoot();
        }
    }
}
