using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    // 스테이지별 획득 별 개수
    public int[] _numberOfStar = new int[11];

    // 총 획득 별 개수
    public int _totalStar = 0;

    // 배경음악 볼륨
    public float musicVol;
    public float btnVol;

    void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            _numberOfStar[i + 1] = 0;
        }
    }
    
    void Update()
    {
        for (int i = 1; i < 11; i++)
        {
            _totalStar = _numberOfStar[i];
        }
    }
}