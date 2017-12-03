using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor_Score : MonoBehaviour
{
    public Text ScoreText;
    public static int score;
    // Use this for initialization
    void Start()
    {
        
        score = 0;
    }

    // Update is called once per frame
   

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rain")
        {
            ScoreText.text = "" + score;
            score++;

            
        }
    }
}
