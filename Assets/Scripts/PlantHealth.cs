using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantHealth : MonoBehaviour
{
    [SerializeField] float plantHealth = 100f;

    float currentHealth;

    private void Start()
    {
        currentHealth = plantHealth;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            PlantDie();
        }
    }

    public void PlantTakeDamage(float damage)
    {
        currentHealth -= damage;
    }

    private void PlantDie()
    {
        Destroy(gameObject);
    }
}
