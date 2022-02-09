using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HyoSoundManager : MonoBehaviour
{
    public Slider btnVolume;

    public AudioSource musicsource; 
    public AudioSource btnsource;

    public StarManager StarManager;

    private float btnvol = 1f;
    
    private void Start() 
    {
        this.StarManager = GameObject.Find("StarManager").GetComponent<StarManager>();
        btnvol = PlayerPrefs.GetFloat("btnvol", 1f);
        btnVolume.value = btnvol;
        btnsource.volume = btnvol;
    }

    private void Update() {
        btnsource.volume = btnvol;
        PlayerPrefs.SetFloat("btnvol", btnvol);
        this.StarManager.btnVol = btnvol;
    }

    public void VolumeUpdater(float volume) {
        btnvol = volume;
    }

    public void OnSfx() {
        btnsource.Play();
    } 
    
}
