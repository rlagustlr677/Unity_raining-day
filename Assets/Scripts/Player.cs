using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    Vector3 player_v;
    Vector3 temp;
    int Right;
    AudioSource umb;

   

  

    public GameObject Score;
    public Floor_Score Score_s;
    int Dir;
    int count;
    // Use this for initialization
    void Start()
    {

        player_v = transform.position;
        Right = -1;
        Dir = 1;
        count = 0;
        umb = gameObject.GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        //  GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10);

        
          player_v = transform.position;

        transform.Translate(Vector3.left * 3.75f * Time.deltaTime);

       

            if (player_v.x > 3.18f && Right == 1)
        {

            player_v.x = -3.18f;
            transform.position = player_v;

        }

        else if (player_v.x < -3.18f && Right == -1)
        {
            player_v.x = 3.18f;
            transform.position = player_v;
        }

       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Item")
        {
            umb.Play();
        }

       
    }

    public void Jump()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 225);


    }

    public void Turn()
    {
        
            Right *= -1;
            Dir *= -1;

            count++;
            transform.rotation = Quaternion.Euler(0, 180 * count, 0);
        


        if (count > 10)
        {
            count = 1;
        }
    }
}
