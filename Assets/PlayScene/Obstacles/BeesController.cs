using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeesController : MonoBehaviour
{
    public bool isBees;
    Vector3 beesPos;
    float addVelocity = 0.03f;

    void Start()
    {
        beesPos = transform.position;
        isBees = false;
    }

    void Update()
    {
        if (isBees)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, beesPos.y, beesPos.z);
            }
            else
            {
                isBees = false;
                transform.position = new Vector3(8.15f, beesPos.y, beesPos.z);
            }
        }
    }
}
