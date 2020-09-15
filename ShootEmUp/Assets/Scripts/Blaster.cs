//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions;

public class Blaster : MonoBehaviour, IWeapon
{
    [SerializeField] private WeaponData weaponData;
    private float fireRate;
    private float damage;
    private GameObject bullet;
    
    private void Awake()
    {
        Assert.IsNotNull(weaponData, this.GetType().Name + " is missing WeaponData.");

        fireRate = weaponData.fireRate;
        damage = weaponData.damage;
        bullet = weaponData.bullet;
        
        PoolManager.Instance.CreatePool(bullet, 2);
        PoolManager.Instance.CreatePool(bullet, 2);
    }

    public void Shoot()
    {
        PoolManager.Instance.ReuseObject(bullet, transform.position, quaternion.identity);
    }
}
