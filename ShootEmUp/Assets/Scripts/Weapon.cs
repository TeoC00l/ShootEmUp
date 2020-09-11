//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private IWeapon weaponSocket;

    private void Awake()
    {
        weaponSocket = new Blaster();
    }
}
