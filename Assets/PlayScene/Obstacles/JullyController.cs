using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JullyController : MonoBehaviour
{
    public bool isJully;
    Vector3 JullyPos;
    float addVelocity = 0.035f;

    void Start()
    {
        JullyPos = transform.position;
        isJully = false;
    }

    void Update()
    {
        if (isJully)
        {
            if (transform.position.x > -10)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, JullyPos.y, JullyPos.z);
            }
            else
            {
                isJully = false;
                transform.position = new Vector3(9.96f, JullyPos.y, JullyPos.z);
            }
        }
    }
}
