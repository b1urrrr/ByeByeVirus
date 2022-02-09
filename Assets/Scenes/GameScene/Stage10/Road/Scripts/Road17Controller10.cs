using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road17Controller10 : MonoBehaviour
{
    public int firstNode;
    public int secondNode;
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
                if (currentPos == firstNode)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage10>().countPatient--;
                    Destroy(GameObject.Find("male3_infected"));
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage10>().currentPos = secondNode;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
                else if (currentPos == secondNode)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage10>().countPatient--;
                    Destroy(GameObject.Find("male3_infected"));
                    GameObject.Find("GameManager").GetComponent<GameManager_Stage10>().currentPos = firstNode;
                    Destroy(hit.transform.gameObject, 0.01f);
                }
            }
        }
    }
}
