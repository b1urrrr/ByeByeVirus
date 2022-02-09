using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Stage8 : MonoBehaviour
{
    public int currentPos;
    public int countPatient;

    void Start()
    {
        currentPos = 1; // 출발지
        countPatient = 5; // 시민 수
    }

    void Update()
    {
        if (currentPos == 7) // 목적지 도달
        {
            currentPos = -1;
            GameObject.Find("Timer").GetComponent<TimerController>().TimerOn = false;
            if (countPatient == 0)
            {
                // Clear 창 활성화
            }
            else
            {
                // Fail 창 활성화
            }
        }

        // 시민 회복
        if (currentPos == 4)
        {
            countPatient--;
            Destroy(GameObject.Find("male1_infected"));
        }
        else if (currentPos == 5)
        {
            countPatient--;
            Destroy(GameObject.Find("female3_infected"));
        }
        else if (currentPos == 6)
        {
            countPatient--;
            Destroy(GameObject.Find("male3_infected"));
        }
        else if (currentPos == 8)
        {
            countPatient--;
            Destroy(GameObject.Find("male2_infected"));
        }
        else if (currentPos == 10)
        {
            countPatient--;
            Destroy(GameObject.Find("female4_infected"));
        }
    }
}
