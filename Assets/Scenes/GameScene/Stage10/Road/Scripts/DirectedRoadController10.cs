using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectedRoadController10 : MonoBehaviour
{
    public int Node;
    int currentPos;

    void Update()
    {
        currentPos = GameObject.Find("GameManager").GetComponent<GameManager_Stage10>().currentPos;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null && hit.collider.transform == this.transform)
            {
                if (currentPos == Node)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage10>().currentPos = -1;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
            }
        }
    }
}
