using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SocialPlatforms;
using GooglePlayGames;
public class Score : MonoBehaviour {
    Text ScoreText;
    public Text BestScore;
    int Cur_score;
    int High_score;
    int Late_High_score;
    string boardId = "CgkIqJby6q8MEAIQAQ";
    // Use this for initialization
    void Start () {
        Cur_score = Floor_Score.score;

       
         //   PlayGamesPlatform.Instance.ReportProgress(GPGSIds.leaderboard_good, 100f, null);
           

        Late_High_score = PlayerPrefs.GetInt("highscore");
        ScoreText = gameObject.GetComponent<Text>();
        
        ScoreText.text ="Score : " + Cur_score;
       if (Cur_score > Late_High_score)
       {
            PlayerPrefs.SetInt("highscore", Cur_score);
            PlayerPrefs.Save();
            PlayGamesPlatform.Instance.ReportScore((long)Cur_score, boardId, null);


        }
        High_score = PlayerPrefs.GetInt("highscore");
        BestScore.text = "Best Score: " + High_score;
    }
	
    
	// Update is called once per frame
	
}
