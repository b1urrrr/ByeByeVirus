using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingScene : MonoBehaviour
{
    public AudioSource BackMusic;

    public void GoToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }    
    void Start() { 
        BackMusic.volume = PlayerPrefs.GetFloat("musicvol");
        BackMusic.Play();
    }
}
