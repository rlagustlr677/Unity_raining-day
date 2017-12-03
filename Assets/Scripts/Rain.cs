using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rain : MonoBehaviour {


    Text ScoreText;
    int score;
    Rigidbody2D rig;
    AudioSource cat_cry;
    
    void Start()
    {
        
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        rig = GetComponent<Rigidbody2D>();
        rig.gravityScale = Random.RandomRange(0.5f, 2.0f);
        cat_cry = GetComponent<AudioSource>();
        
    }

   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Floor"||col.tag=="Player"||col.tag=="Umb")
        {
           
            Destroy(gameObject);
        }

        if (col.tag == "Player")
        {
            Gamemanager.HP -= 10;
            cat_cry.Play();
            if (Gamemanager.HP <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
