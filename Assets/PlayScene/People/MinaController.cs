using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinaController : MonoBehaviour
{
    public bool isMina;
    Vector3 MinaPos;
    float addVelocity = 0.03f;

    void Start()
    {
        MinaPos = transform.position;
        isMina = false;
    }

    void Update()
    {
        if (isMina)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, MinaPos.y, MinaPos.z);
            }
            else
            {
                isMina = false;
                Destroy(gameObject);
            }
        }
    }
}
