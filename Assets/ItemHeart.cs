using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeart : MonoBehaviour {

    // Use this for initialization

    

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            
            if (Gamemanager.HP < 100)
            {
                if (Gamemanager.HP == 90)
                {
                    Rain_Damage.count -= 1;
                    Gamemanager.HP += 10;
                }
                else
                {
                    Rain_Damage.count -= 2;
                    Gamemanager.HP += 20;
                }
            }
            GameObject.Find("GameManager").GetComponent<Gamemanager>().Heart_false_invoke();
            Destroy(gameObject);

        }
    }
}
