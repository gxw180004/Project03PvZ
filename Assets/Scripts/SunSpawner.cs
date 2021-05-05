using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawner : MonoBehaviour
{
    [SerializeField] SunMove sunPrefab = null;
    [SerializeField] int minWaitTime = 15;
    [SerializeField] int maxWaitTime = 30;

    bool spawn = true;
    float randomSpawnTime;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            SpawnSuns();
        }
    }

    private void SpawnSuns()
    {
        SunMove oneSun = Instantiate(sunPrefab, transform.position, Quaternion.identity) as SunMove;

        oneSun.transform.parent = transform;
    }
}
