//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

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
    }

    public void Shoot()
    {
        GameObject shot = Instantiate(bullet);
        shot.transform.position = transform.position;
        shot.GetComponent<Bullet>().direction = transform.up;
    }
}
