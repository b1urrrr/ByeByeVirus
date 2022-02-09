using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class male1Controller1 : MonoBehaviour
{
    int currentPos;

    void Update()
    {
        currentPos = GameObject.Find("GameManager").GetComponent<GameManager_Stage1>().currentPos;

        if (currentPos == 5)
        {
            GameObject.Find("GameManager").GetComponent<GameManager_Stage1>().countPatient--;
            Destroy(gameObject);
        }
    }
}
