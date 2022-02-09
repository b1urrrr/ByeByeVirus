using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Stage3 : MonoBehaviour
{
    public int currentPos;
    public int countPatient;
    public GameObject board;
    public GameObject clearMenu;
    public GameObject failMenu;
    bool isOnce3;
    bool isOnce5;
    bool isOnce7;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    public StarManager StarManager;

    void Start()
    {
        Time.timeScale = 1f;
        currentPos = 1;
        countPatient = 4;
        isOnce3 = true;
        isOnce5 = true;
        isOnce7 = true;
        this.StarManager = GameObject.Find("StarManager").GetComponent<StarManager>();
    }

    void Update()
    {
        if (currentPos == 9)
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
                    this.StarManager._numberOfStar[3] = 3;
                    threeStar.SetActive(true);
                }
                else if (min < 1)
                {
                    if (this.StarManager._numberOfStar[3] < 2)
                        this.StarManager._numberOfStar[3] = 2;
                    twoStar.SetActive(true);
                }
                else
                {
                    if (this.StarManager._numberOfStar[3] < 1)
                        this.StarManager._numberOfStar[3] = 1;
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

        if (currentPos == 3 && isOnce3)
        {
            isOnce3 = false;
            countPatient--;
            Destroy(GameObject.Find("male1_infected"));
        }
        else if (currentPos == 5 && isOnce5)
        {
            isOnce5 = false;
            countPatient--;
            Destroy(GameObject.Find("female2_infected"));
        }
        else if (currentPos == 7 && isOnce7)
        {
            isOnce7 = false;
            countPatient--;
            Destroy(GameObject.Find("male2_infected"));
        }
    }
}
