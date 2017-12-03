using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;
public class GPGDemo : MonoBehaviour
{
    #region PUBLIC_VAR
    public string leaderboard;
    string leaderBoardId = "425157495592";
    #endregion
    #region DEFAULT_UNITY_CALLBACKS


    void Start()
    {
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;

        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();
        LogIn();
    }
    #endregion
    #region BUTTON_CALLBACKS
    /// <summary>
    /// Login In Into Your Google+ Account
    /// </summary>
    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("Login Sucess");
            }
            else
            {
                
            }
        });
    }
    /// <summary>
    /// Shows All Available Leaderborad
    /// </summary>
    public void OnShowLeaderBoard()
    {
        Social.ShowAchievementsUI(); // Show all leaderboard
                                     // ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard); // Show current (Active) leaderboard
    }
    /// <summary>
    /// Adds Score To leader board
    /// </summary>
    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
        
    }
    /// <summary>
    /// On Logout of your Google+ Account
    /// </summary>
    public void OnLogOut()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
    }

   

    /*public void AuthenicateHandler(bool isSuccess)
    {
        if (isSuccess)
        {
            int highScore = PlayerPrefs.GetInt("highScore");
            Social.ReportScore((long)highScore, leaderBoardId, (bool success) =>
            {
                if (success)
                {
                    PlayGamesPlatform.Instance.ShowLeaderboardUI(leaderBoardId);
                    Social.ShowAchievementsUI();
                }
                else
                {

                    
                }
            });
        }
        else
        {

            
        }
    }*/
    #endregion
}