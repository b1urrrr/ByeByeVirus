using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Stage8 : MonoBehaviour
{
    public int currentPos;
    public int countPatient;
    public GameObject board;
    public GameObject clearMenu;
    public GameObject failMenu;
    bool isOnce4;
    bool isOnce5;
    bool isOnce6;
    bool isOnce8;
    bool isOnce10;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    public StarManager StarManager;

    void Start()
    {
        Time.timeScale = 1f;
        currentPos = 1; // 출발지
        countPatient = 5; // 시민 수
        isOnce4 = true;
        isOnce5 = true;
        isOnce6 = true;
        isOnce8 = true;
        isOnce10 = true;
        this.StarManager = GameObject.Find("StarManager").GetComponent<StarManager>();
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
                Time.timeScale = 0f;
                board.SetActive(true);
                clearMenu.SetActive(true);

                // 별 개수 결정
                int min = GameObject.Find("Timer").GetComponent<TimerController>().getMin();
                int sec = GameObject.Find("Timer").GetComponent<TimerController>().getSec();
                if (min < 1 && sec < 30)
                {
                    this.StarManager._numberOfStar[8] = 3;
                    threeStar.SetActive(true);
                }
                else if (min < 1)
                {
                    if (this.StarManager._numberOfStar[8] < 2)
                        this.StarManager._numberOfStar[8] = 2;
                    twoStar.SetActive(true);
                }
                else
                {
                    if (this.StarManager._numberOfStar[8] < 1)
                        this.StarManager._numberOfStar[8] = 1;
                    oneStar.SetActive(true);
                }
            }
            else
            {
                // Fail 창 활성화
                Time.timeScale = 0f;
                board.SetActive(true);
                failMenu.SetActive(true);
            }
        }

        // 시민 회복
        if (currentPos == 4 && isOnce4)
        {
            isOnce4 = false;
            countPatient--;
            Destroy(GameObject.Find("male1_infected"));
        }
        else if (currentPos == 5 && isOnce5)
        {
            isOnce5 = false;
            countPatient--;
            Destroy(GameObject.Find("female3_infected"));
        }
        else if (currentPos == 6 && isOnce6)
        {
            isOnce6 = false;
            countPatient--;
            Destroy(GameObject.Find("male3_infected"));
        }
        else if (currentPos == 8 && isOnce8)
        {
            isOnce8 = false;
            countPatient--;
            Destroy(GameObject.Find("male2_infected"));
        }
        else if (currentPos == 10 && isOnce10)
        {
            isOnce10 = false;
            countPatient--;
            Destroy(GameObject.Find("female4_infected"));
        }
    }
}
