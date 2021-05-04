using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy EnemyPrefab = null;
    [SerializeField] int minWaitTime = 15;
    [SerializeField] int maxWaitTime = 30;

    bool spawn = true;
    float randomSpawnTime;

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
