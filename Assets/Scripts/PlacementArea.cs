using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementArea : MonoBehaviour
{
    Plant plantPrefab = null;

    private void OnMouseDown()
    {
        PlacingPlant(PlaceClicked());
    }

    public void SelectPlant(Plant selectPlant)
    {
        plantPrefab = selectPlant;
    }

    private void PlacingPlant(Vector2 placePos)
    {
        var sunDisplay = FindObjectOfType<SunDisplay>();
        int plantCost = plantPrefab.GetSunCost();

        if(sunDisplay.EnoughSun(plantCost))
        {
            PlacePlant(placePos);
            sunDisplay.SpendSun(plantCost);
        }
    }

    private Vector2 PlaceClicked()
    {
        Vector2 clickedPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickedPos);

        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 placePos)
    {
        float gridX = Mathf.RoundToInt(placePos.x);
        float gridY = Mathf.RoundToInt(placePos.y);
        Vector2 gridPlacePos = new Vector2(gridX, gridY);

        return gridPlacePos;
    }

    private void PlacePlant(Vector2 placePos)
    {
        Plant onePlant = Instantiate(plantPrefab, placePos, Quaternion.identity) as Plant;
    }
}
