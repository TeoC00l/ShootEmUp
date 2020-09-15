//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using UnityEngine;
using UnityEngine.Assertions;

public class Bullet : MonoBehaviour
{
    [SerializeField] private BulletData bulletData;
    [Tooltip("Time in seconds until bullet is deactivated")]
    private float lifeTime;
    
    private float speed = 10f;
    [NonSerialized] public Vector3 direction = Vector3.up;
    
    private float timer;
    
    private void Awake()
    {
        Assert.IsNotNull(bulletData, gameObject.name + " have not been assigned BulletData");
        speed = bulletData.speed;
        lifeTime = bulletData.lifeTime;
    }

    private void OnEnable()
    {
        timer = lifeTime;
    }

    private void Update()
    {
        transform.position += direction * (speed * Time.deltaTime);

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    
}
