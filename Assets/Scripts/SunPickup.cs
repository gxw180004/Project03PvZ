using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPickup : MonoBehaviour
{
    [SerializeField] int sunPickupAmount = 25;

    private void OnMouseDown()
    {
        SunDisplay sunPickup = FindObjectOfType<SunDisplay>();
        sunPickup.PickUpSun(sunPickupAmount);
        Destroy(gameObject);
    }
}
