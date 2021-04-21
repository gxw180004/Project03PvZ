using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float enemyAttackDamage = 5f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;

        if (collision.GetComponent<Plant>())
        {
            GetComponent<Enemy>().isBlocked = true;
            Debug.Log("being attack");
            Plant collidePlant = collideObject.GetComponent<Plant>();
            collidePlant.GetComponent<PlantHealth>().PlantTakeDamage(enemyAttackDamage);
        }
    }
}
