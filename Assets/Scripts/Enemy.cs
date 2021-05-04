using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject currentTarget;

    private void Update()
    {
        updateAnimationState();
    }

    private void updateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void AttackCurrentTarget(float damage)
    {
        if (!currentTarget) { return; }
        PlantHealth health = currentTarget.GetComponent<PlantHealth>();
        if (health)
        {
            health.PlantTakeDamage(damage);
        }
    }


}
