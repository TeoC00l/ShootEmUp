//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using Random = UnityEngine.Random;

[DefaultExecutionOrder(100)]
[ExecuteInEditMode]

public class SpawnChanceSliders : MonoBehaviour
{
    private SpawnManager spawnManager;
    [Range(0, 100)] public int[] sliderValues;

    private void Awake()
    {
        spawnManager = GetComponent<SpawnManager>();
    }

    private void Update()
    {
        UpdateArraySize();
        UpdateSliders();
    }

    private void UpdateArraySize()
    {
        if (spawnManager.spawnObjects.Length == sliderValues.Length)
        {
            return;
        }

        int[] newSpawnPercentageChange = new int[sliderValues.Length+1];

        for (int i = 0; i < sliderValues.Length; i++)
        {
            newSpawnPercentageChange[i] = sliderValues[i];
        }

        sliderValues = newSpawnPercentageChange;
    }

    //TODO: Fix sloppy code, refactor suspect method...
    private void UpdateSliders()
    {
        int subtotal = 0;
        
        for(int i = 0; i < sliderValues.Length; i++)
        {
            subtotal += sliderValues[i];
        }
        
        int errorMargin = subtotal - SpawnManager.NO_OF_TABLE_INDEXES;
        
        while(errorMargin>0)
        {
            int elementToAdjust = Random.Range(0, sliderValues.Length);

            while (sliderValues[elementToAdjust] == 0)
            {
                elementToAdjust = Random.Range(0, sliderValues.Length);
            }
            
            sliderValues[elementToAdjust]--;
            errorMargin--;

        }
        
        while(errorMargin < 0)
        {
            int elementToAdjust = Random.Range(0, sliderValues.Length);
            
            while (sliderValues[elementToAdjust] == 100)
            {
                elementToAdjust = Random.Range(0, sliderValues.Length);
            }
            
            sliderValues[elementToAdjust]++;
            errorMargin++;
        }
    }
}

