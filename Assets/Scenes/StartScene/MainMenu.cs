using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioSource Musicsource;//배경음
    public AudioSource Btnsource;//버튼음 버튼 클릭할 때 넣을까 했는데 배경음을 방해하는 것 같아서 키핑~

    private float volume;//음악 볼륨

    private void Start() {
        Musicsource.volume = PlayerPrefs.GetFloat("musicvol");
        Btnsource.volume = PlayerPrefs.GetFloat("btnvol");
        Musicsource.Play();
    }//시작하면 음악재생

    private void Update() {
        //if(!Musicsource.isPlaying) {
        //    OnMusic();
        //}
    }

    void OnMusic() {
       Musicsource.volume = PlayerPrefs.GetFloat("musicvol");
       Musicsource.Play(); 
    }


    public void GoToStageScene() {
        SceneManager.LoadScene("StageScene");
    }

    public void GoToRankingScene() {
        SceneManager.LoadScene("RankingScene");
    }
}
