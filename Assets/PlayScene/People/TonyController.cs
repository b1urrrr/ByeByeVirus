using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonyController : MonoBehaviour
{
    public bool isTony;
    Vector3 TonyPos;
    float addVelocity = 0.03f;

    void Start()
    {
        TonyPos = transform.position;
        isTony = false;
    }

    void Update()
    {
        if (isTony)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, TonyPos.y, TonyPos.z);
            }
            else
            {
                isTony = false;
                Destroy(gameObject);
            }
        }
    }
}
