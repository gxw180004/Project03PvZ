using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunPickup : MonoBehaviour
{
    [SerializeField] int sunPickupAmount = 25;
    [SerializeField] AudioClip pickUpSFX = null;

    private void OnMouseDown()
    {
        playSFX();
        SunDisplay sunPickup = FindObjectOfType<SunDisplay>();
        sunPickup.PickUpSun(sunPickupAmount);
        Destroy(gameObject);
    }

    void playSFX()
    {
        AudioSource.PlayClipAtPoint(pickUpSFX, transform.position);
    }
}
