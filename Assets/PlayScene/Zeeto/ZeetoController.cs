using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZeetoController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    Vector3 zeetoPos;
    public bool isStart;
    public int servantCount;
    bool isJump;
    bool isBlocked;
    float jumpForce = 850.0f;
    int heart;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        zeetoPos = transform.position;
        isStart = false;
        isJump = false;
        isBlocked = false;
        servantCount = 0;
        heart = 3;
        Invoke("startRun", 1.0f);
    }

    void startRun()
    {
        this.animator.SetTrigger("RunTrigger");
        isStart = true;
        isBlocked = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isBlocked && !isJump && isStart && this.transform.position.y <= -2.7998) // 화면 터치 시 점프
        {
            isJump = true;
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            GetComponent<AudioSource>().Play();
        }
        else if (isStart && !isBlocked && this.rigid2D.velocity.y == 0) // 달리는 애니메이션
        {
            isJump = false;
            this.animator.SetTrigger("RunTrigger");
        }
    }

    void playHit()
    {
        GameObject.Find("hitSound").GetComponent<AudioSource>().Play();
    }

    void playFriend()
    {
        GameObject.Find("friendSound").GetComponent<AudioSource>().Play();
    }

    void transferGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject minsu = GameObject.Find("Minsu");
        GameObject mina = GameObject.Find("Mina");
        GameObject tony = GameObject.Find("Tony");

        if (other.gameObject.tag == "Minsu")
        {
            minsu.GetComponent<MinsuController>().isMinsu = false;
            servantCount++;
            minsu.transform.position = GameObject.Find("MinsuServant").transform.position;
            playFriend();
        } else if (other.gameObject.tag == "Mina")
        {
            mina.GetComponent<MinaController>().isMina = false;
            servantCount++;
            mina.transform.position = GameObject.Find("MinaServant").transform.position;
            playFriend();
        } else if (other.gameObject.tag == "Tony")
        {
            tony.GetComponent<TonyController>().isTony = false;
            servantCount++;
            tony.transform.position = GameObject.Find("TonyServant").transform.position;
            tony.transform.localScale = new UnityEngine.Vector3(-1, 1, 1);
            playFriend();
        }

        if (heart > 1 && other.gameObject.tag == "obstacle")
        {
            isBlocked = true;
            if (heart == 3)
            {
                Destroy(GameObject.Find("heart3"));
            } else if (heart == 2)
            {
                Destroy(GameObject.Find("heart2"));
            }
            playHit();
            heart--;
            this.animator.SetTrigger("BlockTrigger");
            Invoke("startRun", 1.6f);
        } else if (heart == 1 && other.gameObject.tag == "obstacle")
        {
            playHit();
            Destroy(GameObject.Find("heart1"));
            heart--;
            this.animator.SetTrigger("OverTrigger");
            Invoke("transferGameOver", 0.5f);
        }
    }
}
