using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float enemyAttackDamage = 50f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;
 
        if (collision.GetComponent<Plant>())
        {
            GetComponent<Enemy>().isBlocked = true;
            GetComponent<Enemy>().Attack(collideObject);
            Plant collidePlant = collideObject.GetComponent<Plant>();
            collidePlant.GetComponent<PlantHealth>().PlantTakeDamage(enemyAttackDamage);
        }

    }
}
