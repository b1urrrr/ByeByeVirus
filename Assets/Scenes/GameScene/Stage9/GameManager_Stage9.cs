using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Stage9 : MonoBehaviour
{
    public int currentPos;
    public int countPatient;
    public GameObject board;
    public GameObject clearMenu;
    public GameObject failMenu;
    bool isOnce2;
    bool isOnce3;
    bool isOnce6;

    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    public StarManager StarManager;
    public AudioSource music;
    
    void Awake() {
    //음악 소스 가져오기

        //여기까지
        //음악 재생
        music.volume = PlayerPrefs.GetFloat("musicvol");
        music.Play();
        //여기까지
    }

    void Start()
    {
        Time.timeScale = 1f;
        currentPos = 1; // 출발지
        countPatient = 5; // 시민 수
        isOnce2 = true;
        isOnce3 = true;
        isOnce6 = true;
        this.StarManager = GameObject.Find("StarManager").GetComponent<StarManager>();
    }

    void Update()
    {
        if (currentPos == 9) // 목적지 도달
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
                    this.StarManager._numberOfStar[9] = 3;
                    threeStar.SetActive(true);
                }
                else if (min < 1)
                {
                    if (this.StarManager._numberOfStar[9] < 2)
                        this.StarManager._numberOfStar[9] = 2;
                    twoStar.SetActive(true);
                }
                else
                {
                    if (this.StarManager._numberOfStar[9] < 1)
                        this.StarManager._numberOfStar[9] = 1;
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
        if (currentPos == 2 && isOnce2)
        {
            isOnce2 = false;
            countPatient--;
            Destroy(GameObject.Find("male2_infected"));
        }
        else if (currentPos == 3 && isOnce3)
        {
            isOnce3 = false;
            countPatient--;
            Destroy(GameObject.Find("female3_infected"));
        }
        else if (currentPos == 6 && isOnce6)
        {
            isOnce6 = false;
            countPatient--;
            Destroy(GameObject.Find("male1_infected"));
        }
    }
}
