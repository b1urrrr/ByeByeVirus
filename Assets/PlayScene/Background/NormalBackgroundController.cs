using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBackgroundController : MonoBehaviour
{
    Vector3 backPos;
    float addVelocity = 0.02f;
    float addMadVelocity = 0.06f;

    void Start()
    {
        backPos = transform.position;
    }

    void Update()
    {
        if (GameObject.Find("NormalGameDirector").GetComponent<NormalDirector>().isMad)
        {
            if (transform.position.x > -6.66)
            {
                transform.position = new Vector3(transform.position.x - addMadVelocity, backPos.y, backPos.z);
            }
            else
            {
                transform.position = new Vector3(backPos.x, backPos.y, backPos.z);
            }
        }
        else if (GameObject.Find("Zeeto").GetComponent<ZeetoController>().isStart)
        {
            if (transform.position.x > -6.66)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, backPos.y, backPos.z);
            }
            else
            {
                transform.position = new Vector3(backPos.x, backPos.y, backPos.z);
            }
        }
    }
}
