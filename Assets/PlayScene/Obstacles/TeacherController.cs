using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class TeacherController : MonoBehaviour
{
    Vector3 teacherPos;
    int direction;
    float distance = 4.3f;
    float addVelocity = 0.03f;
    public bool isTeacher;
    int once;

    void Start()
    {
        teacherPos = transform.position;
        direction = -1; // -1: 왼쪽, 1: 오른쪽
        once = 0;
        isTeacher = false;
    }

    void changeDirection()
    {
        direction = 1;
    }

    void changeTeacher()
    {
        isTeacher = false;
        once = 0;
    }

    void Update()
    {
        if (isTeacher && direction == -1 && once == 0)
        {
            if (transform.position.x > teacherPos.x - distance)
            {
                transform.position = new Vector3(transform.position.x - addVelocity, teacherPos.y, teacherPos.z);
            }
            else if (once == 0)
            {
                Invoke("changeDirection", 0.5f);
                once = 1;
            }
        }
        else if (isTeacher && direction == 1)
        {
            if (transform.position.x < teacherPos.x)
            {
                transform.position = new Vector3(transform.position.x + addVelocity, teacherPos.y, teacherPos.z);
            }
            else
            {
                Invoke("changeTeacher", 3.0f);
                direction = -1;
            }
        }
    }
}
