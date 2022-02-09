using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadDirector : MonoBehaviour
{
    bool once;
    void Start()
    {
        once = false;
    }

    void startJully()
    {
        GameObject.Find("Jully").GetComponent<JullyController>().isJully = true;
    }

    void startBlackHole()
    {
        GameObject.Find("blackHole").GetComponent<BlackHoleController>().isBlackHole = true;
    }

    void startHeart()
    {
        GameObject.Find("heart").GetComponent<HeartController>().isHeart = true;
    }

    void Update()
    {
        if (GameObject.Find("NormalGameDirector").GetComponent<NormalDirector>().isMad)
        {
            if (!once)
            {
                Invoke("startHeart", 1.0f);
                InvokeRepeating("startJully", 4.0f, 13.0f);
                InvokeRepeating("startBlackHole", 8.0f, 9.0f);
                once = true;
            }

            bool isHeart = GameObject.Find("heart").GetComponent<HeartController>().isHeart;
            bool isMagnet = GameObject.Find("magnet").GetComponent<MagnetController>().isMagnet;
            bool isTeacher = GameObject.Find("teacher").GetComponent<TeacherController>().isTeacher;
            if ((isHeart || isMagnet) && !isTeacher)
            {
                GameObject.Find("teacher").GetComponent<TeacherController>().isTeacher = true;
            }
        }
    }
}
