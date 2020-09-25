//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;

public class Shield : MonoBehaviour
{
    [NonSerialized]public bool isActive = true;

    [SerializeField] private int maxArmor = 5;
    [SerializeField] private GameObject shieldGraphic = default;
    [SerializeField] private GameObject uiMeter = default;
    [SerializeField] private float cooldownTime = 10f;
    [SerializeField] private float shieldStartAnimationTime = 0.3f; 


    private SpriteRenderer spriteRenderer;
    private Transform shieldGraphicTransform;
    private float uiMeterSizeY;
    private float uiMeterSizeZ;


    private int currentArmor = default;

    private void Awake()
    {
        Assert.IsNotNull(shieldGraphic, "Shield has not been assigned a shield graphic");
        Assert.IsNotNull(uiMeter, "Shield has not been assigned a UI-meter");
        
        spriteRenderer = uiMeter.GetComponent<SpriteRenderer>();
        shieldGraphicTransform = shieldGraphic.transform;
        currentArmor = maxArmor;
        
        uiMeterSizeY = uiMeter.transform.localScale.y;
        uiMeterSizeZ = uiMeter.transform.localScale.z;

        UpdateUIMeter(currentArmor);
    }

    public void TakeDamage(int damage)
    {
        currentArmor -= damage;

        if (currentArmor < 0)
        {
            currentArmor = 0;
        }
        
        UpdateUIMeter(currentArmor);

        if (currentArmor == 0)
        {
            StartCoroutine(Cooldown());
        }
    }
    
    private void UpdateUIMeter(float uiMeterSizeX)
    {
        uiMeter.transform.localScale = new Vector3(uiMeterSizeX, uiMeterSizeY, uiMeterSizeZ);
    }

    private IEnumerator Cooldown()
    {
        isActive = false;
        shieldGraphic.SetActive(isActive);
        
        spriteRenderer.color = Color.red;

        for (float recoverPerFrame = 0; recoverPerFrame <= maxArmor; recoverPerFrame += Time.deltaTime * maxArmor / cooldownTime)
        {
            UpdateUIMeter(recoverPerFrame);
            yield return null;
        }
        
        spriteRenderer.color = Color.green;
        isActive = true;
        shieldGraphic.SetActive(isActive);
        StartCoroutine(StartShieldAnimation());
        currentArmor = maxArmor;
    }

    //TODO: BREAK THE SHIELD BAR ANIMATION STUFF INTO SEPARATE CLASS
    private IEnumerator StartShieldAnimation()
    {
        float shieldSize = shieldGraphicTransform.transform.localScale.x;
        shieldGraphic.transform.localScale = Vector3.zero;
        
        for (float f = 0; f < shieldSize; f += Time.deltaTime * shieldSize / shieldStartAnimationTime)
        {
            shieldGraphic.transform.localScale = new Vector3(f, f, f);
            yield return null;
        }
    }
}
