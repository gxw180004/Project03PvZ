using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaBullet : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float bulletDamage = 10f;
    [SerializeField] AudioClip damageSFX = null;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemyHealth = collision.GetComponent<EnemyHealth>();
        enemyHealth.EnemyTakeDamage(bulletDamage);
        AudioSource.PlayClipAtPoint(damageSFX, transform.position);
        Destroy(gameObject);
    }
}
