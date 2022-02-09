using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road9Controller1 : MonoBehaviour
{
    int currentPos;

    void Update()
    {
        currentPos = GameObject.Find("GameManager").GetComponent<GameManager_Stage1>().currentPos;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                if (currentPos == 8)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage1>().currentPos = 5;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
                else if (currentPos == 5)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage1>().currentPos = 8;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
            }
        }
    }
}
