using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMSoundMagager : MonoBehaviour
{
    public Slider MusicVolume;
    public AudioSource musicsource;

    public StarManager StarManager;

    private float musicvol = 1f; 

    private void Start() 
    {
        this.StarManager = GameObject.Find("StarManager").GetComponent<StarManager>();
        //musicsource.Play();
        musicvol = PlayerPrefs.GetFloat("musicvol", 1f);
        MusicVolume.value = musicvol;
        musicsource.volume = musicvol;
    }

    private void Update() {
        musicsource.volume = musicvol;
        PlayerPrefs.SetFloat("musicvol", musicvol);
        this.StarManager.musicVol = musicvol;
    }

    public void VolumeUpdater(float volume) {
        musicvol = volume;
    }
}
