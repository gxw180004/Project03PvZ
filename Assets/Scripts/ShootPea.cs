using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPea : MonoBehaviour
{
    [SerializeField] GameObject peaPrefab = null;
    [SerializeField] Transform firePoint = null;
    [SerializeField] float fireRate = 1f;

    float fireCountDown = 0f;
    EnemySpawner laneSpawner;
    Animator animator;

    private void Start()
    {
        SetLaneSpawners();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (LaneTarget())
        {
            if (fireCountDown <= 0f)
            {
                animator.SetBool("isAttacking",true);
                Shoot();
                fireCountDown = 1f / fireRate;
            }
            fireCountDown -= Time.deltaTime;
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawners()
    {
        EnemySpawner[] EnemySpawners = FindObjectsOfType<EnemySpawner>();

        foreach (EnemySpawner EnemySpawner in EnemySpawners)
        {
            bool sameLane = Mathf.Abs(EnemySpawner.transform.position.y - transform.position.y) <= Mathf.Epsilon;

            if (sameLane)
            {
                laneSpawner = EnemySpawner;
            }
        }
    }

    private bool LaneTarget()
    {
        if(laneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void Shoot()
    {
        GameObject peaBullet = Instantiate(peaPrefab, firePoint.position, Quaternion.identity) as GameObject;
        Destroy(peaBullet, 4f);
    }
}
