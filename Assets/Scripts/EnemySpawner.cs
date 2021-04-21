using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy EnemyPrefab = null;

    bool spawn = true;
    float randomSpawnTime;
    int minWaitTime = 1;
    int maxWaitTime = 5;

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
        Enemy oneEnemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity) as Enemy;

        oneEnemy.transform.parent = transform;
    }
}
