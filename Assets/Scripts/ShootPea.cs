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

    private void Start()
    {
        SetLaneSpawners();
    }

    private void Update()
    {
        /*
        if (fireCountDown <= 0f)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }
        fireCountDown -= Time.deltaTime;
        */
        if (LaneTarget())
        {
            Debug.Log("shoot");
            //shoot
        }
        else
        {
            Debug.Log("sit and wait");
            //dont shoot
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
