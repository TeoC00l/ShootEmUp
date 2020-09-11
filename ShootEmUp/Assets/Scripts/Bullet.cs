//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using UnityEngine;
using UnityEngine.Assertions;

public class Bullet : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    [NonSerialized] public float speed;
    [NonSerialized] public float direction;

    private void Awake()
    {
        Assert.IsNotNull(bulletData, gameObject.name + " have not been assigned BulletData");
    }
}
