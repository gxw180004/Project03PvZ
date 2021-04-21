using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    void Update()
    {
        if(GetComponent<Enemy>().isBlocked == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
        else if(GetComponent<Enemy>().isBlocked == true)
        {
            transform.Translate(Vector2.zero);
        }
        
    }
}
