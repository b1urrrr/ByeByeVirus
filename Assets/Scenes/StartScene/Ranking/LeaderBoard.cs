using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class LeaderBoard : MonoBehaviour
{
    public void OpenLeaderboard(){
        Social.ShowLeaderboardUI();
    }

    public void UpdateLeaderboardScore() {
        if(PlayerPrefs.GetInt("ScoreToUpdate", 0) == 0)
        {
            return;
        }

        Social.ReportScore(PlayerPrefs.GetInt("ScoreToUpdate", 1), 
        "CgkIiuzU_JcfEAIQAg",(bool success) => {
            if(success)
            {
                PlayerPrefs.SetInt("ScoreToUpdate", 0);
            }
        });
    }
}
