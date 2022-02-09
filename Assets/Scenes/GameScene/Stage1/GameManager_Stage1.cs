using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager_Stage1 : MonoBehaviour
{
    public int currentPos;
    public int countPatient;

    public GameObject board;
    public GameObject clearMenu;
    public GameObject failMenu;

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
        currentPos = 1;
        countPatient = 2;
        Time.timeScale = 1f;
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
                    this.StarManager._numberOfStar[1] = 3;
                    threeStar.SetActive(true);
                }
                else if (min < 1)
                {   
                    if (this.StarManager._numberOfStar[1] < 2)
                        this.StarManager._numberOfStar[1] = 2;
                    twoStar.SetActive(true);
                }
                else
                {
                    if (this.StarManager._numberOfStar[1] < 1)
                        this.StarManager._numberOfStar[1] = 1;
                    oneStar.SetActive(true);
                }

            } else
            {
                // Fail 창 활성화
                Time.timeScale = 0f;
                board.SetActive(true);
                failMenu.SetActive(true);
            }
        }
    }
}
