using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController_Stage : MonoBehaviour
{
    public StarManager StarManager;

    public GameObject[] NumOfStar1 = new GameObject[10];
    public GameObject[] NumOfStar2 = new GameObject[10];
    public GameObject[] NumOfStar3 = new GameObject[10];

    void Start()
    {
        this.StarManager = GameObject.Find("StarManager").GetComponent<StarManager>();
    }

    void Update()
    {
        for(int i = 0; i < 10; i++)
        {
            if (this.StarManager._numberOfStar[i + 1] == 3)
            {
                NumOfStar3[i].SetActive(true);
            } else if (this.StarManager._numberOfStar[i + 1] == 2)
            {
                NumOfStar2[i].SetActive(true);
            } else if (this.StarManager._numberOfStar[i + 1] == 1)
            {
                NumOfStar1[i].SetActive(true);
            }
        }
    }
}
