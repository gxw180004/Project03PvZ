using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float levelTime = 10f;

    private void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool endOfLevel = (Time.timeSinceLevelLoad >= levelTime);

        if (endOfLevel)
        {
            Debug.Log("");
        }
    }
}
