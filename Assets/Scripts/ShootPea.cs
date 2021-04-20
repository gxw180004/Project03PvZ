using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPea : MonoBehaviour
{
    [SerializeField] GameObject peaPrefab = null;
    [SerializeField] Transform firePoint = null;
    [SerializeField] float fireRate = 1f;
    float fireCountDown = 0f;

    private void Update()
    {
        if (fireCountDown <= 0f)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }
        fireCountDown -= Time.deltaTime;
    }

    private void Shoot()
    {
        GameObject peaBullet = Instantiate(peaPrefab, firePoint.position, Quaternion.identity) as GameObject;
        Destroy(peaBullet, 4f);
    }
}
