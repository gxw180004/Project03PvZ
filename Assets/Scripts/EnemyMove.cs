using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float moveSpeed = 0.0005f;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        moveSpeed = speed;
    }
}
