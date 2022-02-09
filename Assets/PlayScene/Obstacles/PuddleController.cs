using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleController : MonoBehaviour
{
    public bool isPuddle;
    Vector3 puddlePos;
    float addVelocity = 0.03f;

    void Start()
    {
        puddlePos = transform.position;
        isPuddle = false;
    }

    void Update()
    {
        if (isPuddle)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, puddlePos.y, puddlePos.z);
            }
            else
            {
                isPuddle = false;
                transform.position = new Vector3(8.312f, puddlePos.y, puddlePos.z);
            }
        }
    }
}
