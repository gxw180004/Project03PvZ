using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantButton : MonoBehaviour
{
    [SerializeField] Plant plantPrefab = null;
    [SerializeField] AudioClip pickUpSFX = null;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<PlantButton>();

        AudioSource.PlayClipAtPoint(pickUpSFX,transform.position);

        foreach(PlantButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41,41,41,255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;

        FindObjectOfType<PlacementArea>().SelectPlant(plantPrefab);
    }
}
