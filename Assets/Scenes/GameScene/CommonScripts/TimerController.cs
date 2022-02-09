using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public bool TimerOn;
    float time;
    string min;
    string sec;
    public Text timer;
    public Text result;

    void Start()
    {
        TimerOn = true;
        time = 0;
        min = "0";
        sec = "0";
    }

    void Update()
    {
        result.text = timer.text;
        if (TimerOn)
        {
            time += Time.deltaTime;
            sec = ((int)time % 60).ToString();
            min = ((int)time / 60 % 60).ToString();
            timer.text = min + "." + sec;
        }
    }

    public int getMin()
    {
        return (int)time / 60 % 60;
    }

    public int getSec()
    {
        return (int)time % 60;
    }
}
