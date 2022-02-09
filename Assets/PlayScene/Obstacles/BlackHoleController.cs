using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleController : MonoBehaviour
{
    public bool isBlackHole;
    Vector3 blackHolePos;
    float addVelocity = 0.035f;

    void Start()
    {
        blackHolePos = transform.position;
        isBlackHole = false;
    }

    void Update()
    {
        if (isBlackHole)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, blackHolePos.y, blackHolePos.z);
            }
            else
            {
                isBlackHole = false;
                transform.position = new Vector3(8.12f, blackHolePos.y, blackHolePos.z);
            }
        }
    }
}
