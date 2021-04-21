using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject currentTarget;

    public bool isBlocked;

    private void Start()
    {
        isBlocked = false;
    }

    public void Attack(GameObject target)
    {
        currentTarget = target;
    }
}
