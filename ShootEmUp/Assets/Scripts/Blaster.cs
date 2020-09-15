//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions;

public class Blaster : MonoBehaviour, IWeapon
{
    public bool IsShooting { get; set; }

    [SerializeField] private WeaponData weaponData;
    private float fireRate;
    private float fireCooldown;
    private float damage;
    private GameObject bullet;
    
    private void Awake()
    {
        Assert.IsNotNull(weaponData, this.GetType().Name + " is missing WeaponData.");

        fireRate = weaponData.fireRate;
        damage = weaponData.damage;
        bullet = weaponData.bullet;
        
        PoolManager.Instance.CreatePool(bullet,10);
    }

    private void OnEnable()
    {
        fireCooldown = 0;
    }
    
    private void Update()
    {
        if (fireRate > 0)
        {
            fireCooldown -= Time.deltaTime;
        }
    }

    public void Shoot()
    {
        if (fireCooldown > 0)
        {
            return;
        }
        
        PoolManager.Instance.ReuseObject(bullet, transform.position, quaternion.identity);
        fireCooldown = fireRate;
    }
}
