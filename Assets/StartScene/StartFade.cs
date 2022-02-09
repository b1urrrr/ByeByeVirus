using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartFade : MonoBehaviour
{
    public Image fadeImg;

    float totalFadeTime = 1;

    public Color destColor;
    Color oriColor;

    // Start is called before the first frame update
    private void Start()
    {
        oriColor = fadeImg.color;
    }

    public void Fade()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine(Fade_());
    }

    IEnumerator Fade_()
    {
        float curTime = 0;

        while(curTime < totalFadeTime)
        {
            curTime += Time.deltaTime;
            fadeImg.color = Color.Lerp(oriColor, destColor, curTime);

            yield return null;
        }
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
   // void Update()
   // {
    //    
   // }
}
