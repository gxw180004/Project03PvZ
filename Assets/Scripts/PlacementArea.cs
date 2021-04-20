﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementArea : MonoBehaviour
{
    [SerializeField] GameObject plantPrefab = null;

    private void OnMouseDown()
    {
        PlacePlant(PlaceClicked());
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
        GameObject onePlant = Instantiate(plantPrefab, placePos, Quaternion.identity) as GameObject;
    }
}