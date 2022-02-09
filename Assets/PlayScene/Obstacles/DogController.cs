using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public bool isDog;
    Vector3 dogPos;
    float addVelocity = 0.03f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        dogPos = transform.position;
        isDog = false;
    }

    void Update()
    {
        if (isDog)
        {
            if (transform.position.x > -8)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, dogPos.y, dogPos.z);
            }
            else
            {
                isDog = false;
                transform.position = new Vector3(8.18f, dogPos.y, dogPos.z);
            }
        }
    }
}
