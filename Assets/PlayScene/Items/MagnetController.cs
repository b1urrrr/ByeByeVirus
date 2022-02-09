using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetController : MonoBehaviour
{
    GameObject zeeto;
    public bool isMagnet;
    Vector3 magnetPos;
    float addVelocity = 0.03f;

    void Start()
    {
        zeeto = GameObject.Find("Zeeto");
        magnetPos = transform.position;
        isMagnet = false;
    }

    void Update()
    {
        if (isMagnet)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, zeeto.transform.position.y + 3.2f, magnetPos.z);
            }
            else
            {
                isMagnet = false;
                transform.position = new Vector3(7.87f, 0.99f, 0.0f);
            }
        }
        
    }
}
