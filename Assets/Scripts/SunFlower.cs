using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    [SerializeField] GameObject sunPrefab = null;
    [SerializeField] Transform generatePoint = null;

    float countDown = 3f;
    float tempCountDown;

    private void Start()
    {
        tempCountDown = countDown;
        countDown = Random.Range(6f, 11f);
    }

    private void Update()
    {
        countDown = Random.Range(5f, 8f);

        if (tempCountDown <= 0)
        {
            GenerateSun();
            tempCountDown = countDown;
        }
        tempCountDown -= Time.deltaTime;
    }

    private void GenerateSun()
    {
        GameObject oneSun = Instantiate(sunPrefab, generatePoint.position, Quaternion.identity) as GameObject;
        //var rb = oneSun.GetComponent<Rigidbody2D>();
        //rb.velocity = Vector2.up;
        Destroy(oneSun, 5f);
    }
}
