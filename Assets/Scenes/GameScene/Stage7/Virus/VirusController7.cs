using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController7 : MonoBehaviour
{
    public GameObject board;
    public GameObject failMenu;

    Vector3 virusPos;
    float distance = 1.2f;
    float addXVelocity = 0.6f;
    float addYVelocity = 0f;
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
            if (transform.position.x > virusPos.x - distance)
            {
                transform.position = new Vector3(transform.position.x - addXVelocity * Time.deltaTime, transform.position.y - addYVelocity * Time.deltaTime, virusPos.z);

            }
            else direction = -1;
        }
        else
        {
            if (transform.position.x < virusPos.x)
            {
                transform.position = new Vector3(transform.position.x + addXVelocity * Time.deltaTime, transform.position.y + addYVelocity * Time.deltaTime, virusPos.z);
            }
            else direction = 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager_Stage7>().currentPos == 3)
            {
                Time.timeScale = 0f;
                board.SetActive(true);
                failMenu.SetActive(true);
            }
        }
        else if (other.tag == "Respawn")
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager_Stage7>().currentPos == 4)
            {
                Time.timeScale = 0f;
                board.SetActive(true);
                failMenu.SetActive(true);
            }
        }
    }
}
