//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;

public class Blaster : IWeapon
{
    private WeaponData weaponData;
    private float fireRate;
    private float damage;

    [SerializeField] private Bullet bullet;

    private void Awake()
    {
        Assert.IsNotNull(bullet, this.GetType().Name + " is missing bullet.");
        Assert.IsNotNull(weaponData, this.GetType().Name + " is missing WeaponData.");

        fireRate = weaponData.fireRate;
        damage = weaponData.damage;
    }
    
    public void Shoot()
    {
        //Take bullet out of object pool, place here and initiate it with a direction
        
    }
}
