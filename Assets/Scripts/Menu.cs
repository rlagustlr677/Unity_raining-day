using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using UnityEngine.SocialPlatforms;
using GooglePlayGames;


public class Menu : MonoBehaviour
{

    public Text BestScore;
   
    int Late_High_score;
    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }


   


   



}
