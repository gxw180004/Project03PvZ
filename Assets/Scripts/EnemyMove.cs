using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    Enemy enemy;

    void Update()
    {
        if(enemy.isBlocked == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
        else
        {
            transform.Translate(Vector2.zero);
        }
        
    }
}
