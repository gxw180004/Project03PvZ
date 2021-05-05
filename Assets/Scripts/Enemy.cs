using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip brainSFX = null;

    GameObject currentTarget;

    private void Awake()
    {
        AudioSource.PlayClipAtPoint(brainSFX, transform.position);
    }

    private void Update()
    {
        updateAnimationState();
    }

    private void updateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
            GetComponent<AudioSource>().enabled = false;
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
