using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_spawn : MonoBehaviour
{




    // Use this for initialization









    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {

            GameObject.Find("GameManager").GetComponent<Gamemanager>().itemuse();

            Destroy(gameObject);

        }
    }


}
