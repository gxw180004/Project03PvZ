using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesAreComing : MonoBehaviour
{
    [SerializeField] float waitTime = 12f;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);

        StartCoroutine(PlaySFX());
    }

    IEnumerator PlaySFX()
    {
        audioSource.enabled = true;
        audioSource.Play();

        yield return new WaitForSeconds(4f);

        Destroy(gameObject);
    }
}
