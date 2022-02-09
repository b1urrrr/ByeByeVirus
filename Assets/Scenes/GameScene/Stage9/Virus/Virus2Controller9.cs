using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus2Controller9 : MonoBehaviour
{
    public GameObject board;
    public GameObject failMenu;

    Vector3 virusPos;
    float distance = 2.4f;
    float addXVelocity = 0f;
    float addYVelocity = 0.75f;
    float direction;

    void Start()
    {
        virusPos = transform.position;
        direction = 1;
    }

    void Update()
    {
        // 바이러스 이동 방향 : 왼쪽(1), 오른쪽(-1)
        if (direction == 1)
        {
            if (transform.position.y > virusPos.y - distance)
            {
                transform.position = new Vector3(transform.position.x - addXVelocity * Time.deltaTime, transform.position.y - addYVelocity * Time.deltaTime, virusPos.z);

            }
            else direction = -1;
        }
        else
        {
            if (transform.position.y < virusPos.y)
            {
                transform.position = new Vector3(transform.position.x + addXVelocity * Time.deltaTime, transform.position.y + addYVelocity * Time.deltaTime, virusPos.z);
            }
            else direction = 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager_Stage9>().currentPos == 5)
            {
                Time.timeScale = 0f;
                board.SetActive(true);
                failMenu.SetActive(true);
            }
        }
        else if (other.tag == "BackGroundList")
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager_Stage9>().currentPos == 7)
            {
                Time.timeScale = 0f;
                board.SetActive(true);
                failMenu.SetActive(true);
            }
        }
    }
}
