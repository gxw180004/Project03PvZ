using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] int sunCost = 50;

    public int GetSunCost()
    {
        return sunCost;
    }
}
