using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public string thisStage;
    public string nextStage;
    public GameObject board;
    public GameObject pauseMenu;


    public void Pause()
    {
        Time.timeScale = 0f;
        board.SetActive(true);
        pauseMenu.SetActive(true);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StageScene");
    }

    public void GoToNextStage()
    {
        SceneManager.LoadScene(nextStage);
    }

    public void Retry()
    {
        SceneManager.LoadScene(thisStage, LoadSceneMode.Single);
    }

    public void resume()
    {
        board.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
