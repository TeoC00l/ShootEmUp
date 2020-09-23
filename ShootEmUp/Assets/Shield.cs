//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using UnityEngine;
using UnityEngine.Assertions;

public class Shield : MonoBehaviour
{
    [NonSerialized]public bool isActive;

    [SerializeField] private int maxArmor;
    [SerializeField] private GameObject shieldGraphic = default;

    private int currentArmor = default;

    private void Awake()
    {
        Assert.IsNotNull(shieldGraphic, "Shield has not been assigned a shield graphic");
    }

    public void takeDamage(int damage)
    {
        currentArmor -= damage;
        
        if (currentArmor <= 0)
        {
            isActive = false;
        }
    }
    
    
}
