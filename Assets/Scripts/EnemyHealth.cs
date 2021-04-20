using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyHealth = 100f;

    float currentHealth;
    
    private void Start()
    {
        currentHealth = enemyHealth;
    }

    private void Update()
    {
        if(currentHealth <= 0)
        {
            EnemyDie();
        }
    }

    public void EnemyTakeDamage(float damage)
    {
        currentHealth -= damage;
    }

    private void EnemyDie()
    {
        Destroy(gameObject);
    }
}
