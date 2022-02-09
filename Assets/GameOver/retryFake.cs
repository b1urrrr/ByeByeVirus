using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retryFake : MonoBehaviour
{
    bool retryCap;
    void Start()
    {
        retryCap = false;
        Invoke("changeRetry", 3.0f);
    }

    void changeRetry()
    {
        retryCap = true;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && retryCap)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
