using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunDisplay : MonoBehaviour
{
    [SerializeField] int initialSunAmount = 10000;
    Text sunAmountText = null;

    private void Start()
    {
        sunAmountText = GetComponent<Text>();
        updateSunAmount();
    }

    private void updateSunAmount()
    {
        sunAmountText.text = initialSunAmount.ToString();
    }

    public void PickUpSun(int sunAmount)
    {
        initialSunAmount += sunAmount;
        updateSunAmount();
    }

    public void SpendSun(int sunAmount)
    {
        if(initialSunAmount >= sunAmount)
        {
            initialSunAmount -= sunAmount;
            updateSunAmount();
        }
    }

    public bool EnoughSun(int costAmount)
    {
        return initialSunAmount >= costAmount;
    }
}
