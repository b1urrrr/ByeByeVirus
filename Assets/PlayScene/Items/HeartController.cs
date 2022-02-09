using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public bool isHeart;
    Vector3 heartPos;
    int direction;
    float distance = 7.0f;
    float addVelocity = 0.03f;

    void Start()
    {
        heartPos = transform.position;
        direction = -1; // -1: 왼쪽, 1: 오른쪽
        isHeart = false;
    }

    void Update()
    {
        if (isHeart && direction == -1)
        {
            if (transform.position.x > heartPos.x - distance)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, heartPos.y, heartPos.z);
            }
            else direction = 1;
        }
        else if (isHeart)
        {
            if (transform.position.x < heartPos.x)
            {
                transform.position = new Vector3(transform.position.x + addVelocity, heartPos.y, heartPos.z);
            }
            else
            {
                isHeart = false;
                direction = -1;
            }
        }
    }
}
