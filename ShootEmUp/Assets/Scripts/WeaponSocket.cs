//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;

public class WeaponSocket : MonoBehaviour
{
    private GameObject[] weapons;
    private IWeapon currentWeapon;
    private int currentWeaponIndex = default;
    private bool isShooting;

    private void Awake()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapon");
        
        Assert.IsNotNull(weapons);

        currentWeapon = weapons[currentWeaponIndex].GetComponent<IWeapon>();

        foreach (GameObject weapon in weapons)
        {
            weapon.gameObject.SetActive(false);
        }
        
        weapons[currentWeaponIndex].SetActive(true);
    }

    private void OnShoot(InputValue value)
    {
        isShooting = value.isPressed;
    }

    private void OnCycleWeapon()
    {
        weapons[currentWeaponIndex].SetActive(false);
        
        if (currentWeaponIndex == weapons.Length-1)
        {
            currentWeaponIndex = 0;
        }
        else
        {
            currentWeaponIndex++;
        }

        weapons[currentWeaponIndex].SetActive(true);
        currentWeapon = weapons[currentWeaponIndex].GetComponent<IWeapon>();
    }

    private void Update()
    {
        if (isShooting)
        {
            currentWeapon.Shoot();
        }
    }
}
