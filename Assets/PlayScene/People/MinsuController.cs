using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinsuController : MonoBehaviour
{
    public bool isMinsu;
    Vector3 MinsuPos;
    float addVelocity = 0.03f;

    void Start()
    {
        MinsuPos = transform.position;
        isMinsu = false;
    }

    void Update()
    {
        if (isMinsu)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, MinsuPos.y, MinsuPos.z);
            }
            else
            {
                isMinsu = false;
                Destroy(gameObject);
            }
        }
    }
}
