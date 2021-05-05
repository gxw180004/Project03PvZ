using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPea : MonoBehaviour
{
    [SerializeField] GameObject peaPrefab = null;
    [SerializeField] Transform firePoint = null;
    [SerializeField] float fireRate = 1f;
    [SerializeField] AudioClip pickUpSFX = null;

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
            animator.SetBool("isAttacking", true);
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
        AudioSource.PlayClipAtPoint(pickUpSFX, transform.position);
        Destroy(peaBullet, 4f);
    }
}
