using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float enemyAttackDamage = 50f;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;

        if (collision.GetComponent<Plant>())
        {
            GetComponent<Enemy>().Attack(collideObject);
            GetComponent<AudioSource>().enabled = true;
            AudioSource sfx = GetComponent<AudioSource>();
            sfx.Play();
            Plant collidePlant = collideObject.GetComponent<Plant>();
            collidePlant.GetComponent<PlantHealth>().PlantTakeDamage(enemyAttackDamage);
        }
    }
}
