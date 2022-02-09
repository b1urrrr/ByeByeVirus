using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road5Controller3 : MonoBehaviour
{
    int currentPos;

    void Update()
    {
        currentPos = GameObject.Find("GameManager").GetComponent<GameManager_Stage3>().currentPos;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                if (currentPos == 3)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage3>().currentPos = 6;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
                else if (currentPos == 6)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage3>().currentPos = 3;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
            }
        }
    }
}
