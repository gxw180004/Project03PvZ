using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab = null;

    bool spawn = true;
    float randomSpawnTime;
    int minWaitTime = 1;
    int maxWaitTime = 10;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            SpawnEnemies();
        }
    }

    private void SpawnEnemies()
    {
        Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
    }
}
