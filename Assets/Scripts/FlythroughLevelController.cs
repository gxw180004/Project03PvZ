using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlythroughLevelController : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;

    private void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene("Level1");
    }
}
