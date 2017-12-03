using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rain_Damage : MonoBehaviour {

    Animator anim;   
    AudioSource cat_cry;
    public static int count;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        count = 0;
        cat_cry = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Gamemanager.HP == 90 && count == 0)
        {
            DamageFunction();
        }

        else if (Gamemanager.HP == 80 && count == 1)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 70 && count == 2)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 60 && count == 3)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 50 && count == 4)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 40 && count == 5)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 30 && count == 6)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 20 && count == 7)
        {
            DamageFunction();
        }
        else if (Gamemanager.HP == 10 && count == 8)
        {
            DamageFunction();
        }

    }

    void DamageFunction()
    {
        cat_cry.Play();
        anim.SetTrigger("Damage");
        count++;
        anim.SetTrigger("Idle");
    }
}
