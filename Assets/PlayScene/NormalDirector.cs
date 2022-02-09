using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDirector : MonoBehaviour
{
    public bool isMad;
    void Start()
    {
        isMad = false;
        Invoke("startMinsu", 30.0f);
        Invoke("startMina", 15.0f);
        Invoke("startTony", 45.0f);
        InvokeRepeating("startMagnet", 20.0f, 20.0f);
        InvokeRepeating("startHeart", 35.0f, 35.0f);
        InvokeRepeating("startDog", 4.0f, 19.0f);
        InvokeRepeating("startBees", 13.0f, 8.0f);
        InvokeRepeating("startPuddle", 7.0f, 10.0f);
    }

    void startMagnet()
    {
        GameObject.Find("magnet").GetComponent<MagnetController>().isMagnet = true;
    }

    void startHeart()
    {
        GameObject.Find("heart").GetComponent<HeartController>().isHeart = true;
    }

    void startMinsu()
    {
        GameObject.Find("Minsu").GetComponent<MinsuController>().isMinsu = true;
    }

    void startMina()
    {
        GameObject.Find("Mina").GetComponent<MinaController>().isMina = true;
    }

    void startTony()
    {
        GameObject.Find("Tony").GetComponent<TonyController>().isTony = true;
    }

    void startDog()
    {
        GameObject.Find("dog").GetComponent<DogController>().isDog = true;
    }

    void startPuddle()
    {
        GameObject.Find("puddle").GetComponent<PuddleController>().isPuddle = true;
    }

    void startBees()
    {
        GameObject.Find("bees").GetComponent<BeesController>().isBees = true;
    }

    void changeMode()
    {
        GetComponent<AudioSource>().Play();
        GameObject.Find("Main Camera").GetComponent<AudioSource>().mute = true;
        Destroy(GameObject.Find("Minsu"));
        Destroy(GameObject.Find("Mina"));
        Destroy(GameObject.Find("Tony"));
        Destroy(GameObject.Find("NormalBackground"));
        isMad = true;
    }

    void Update()
    {
        if (GameObject.Find("Zeeto").GetComponent<ZeetoController>().servantCount == 3)
        {
            GameObject.Find("Zeeto").GetComponent<ZeetoController>().servantCount++;
            Invoke("changeMode", 0.5f);
        }
    }
}
