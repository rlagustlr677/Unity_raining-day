using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour {


    public GameObject Rain;
    public GameObject Item;
    public GameObject ScoreText;
    public Text HPText;
    public Floor_Score score_s;
    public int round_c;
    public int Item_c;
    public GameObject Umb;
    public bool get_item;

    public GameObject Heart;


    public static bool Heart_flag;
    public static int HP;
    public static bool item_flag;
    //  public GameObject player;
    // Use this for initialization
    void Start () {
        
        round_c = 1;
        get_item = false;
        InvokeRepeating("CreateObjects", 1f, 0.5f);
        

        Umb.SetActive(false);
      
        item_flag = true;
        Heart_flag = true;
        Invoke("item_flag_false", 3f);
        Invoke("Heart_flag_false", 15f);
        HP = 100;

        
    }

	// Update is called once per frame
	void Update () {


        CreateItems();
        CreateHeart();
        stage();
        HPText.text = "HP : " + HP;
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Mainmenu");
        }

        

    }

    void CreateObjects()
    {
        Instantiate(Rain, new Vector3(Random.RandomRange(-3.0f, 3.0f), 7, 0), Quaternion.identity);
    }

    void CreateItems()
    {
        if (!item_flag)
        {
            Instantiate(Item, new Vector3(Random.RandomRange(-2.7f, 2.7f),-2.5f, 0), Quaternion.identity);
            item_flag = true;
        }
    }

    void CreateHeart()
    {
        if (!Heart_flag)
        {
            Instantiate(Heart, new Vector3(Random.RandomRange(-2.7f, 2.7f), Random.RandomRange(-2.5f, 1.6f), 0), Quaternion.identity);
            Heart_flag = true;
        }
    }

    void item_flag_false()
    {
        item_flag = false;
    }
    
    
    void Heart_flag_false()
    {
        Heart_flag = false;
    }

    public void Heart_false_invoke()
    {      
        Invoke("Heart_flag_false", 10f);
    }

    public void umb_true()
    {
        Umb.SetActive(true);
    }

    public void umb_false()
    {
        Umb.SetActive(false);
    }

    public void umb_false_invoke()
    {
        
        Invoke("umb_false", 6f);
        Invoke("item_flag_false", 10f);
    }

    public void itemuse()
    {
       

            umb_true();
            umb_false_invoke();
        
        
    }
   
   
    void stage()
    {
        if (Floor_Score.score > 10 && round_c == 1)
        {
            
            
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.5f);
            round_c++;
        }

        else if (Floor_Score.score > 100 && round_c == 2)
        {
            
            GameObject.FindGameObjectWithTag("bg1").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.4f);
            round_c++;
        }

        else if (Floor_Score.score > 200 && round_c == 3)
        {
            GameObject.FindGameObjectWithTag("bg2").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.3f);
            round_c++;
        }
        else if (Floor_Score.score > 300 && round_c == 4)
        {
            GameObject.FindGameObjectWithTag("bg3").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.2f);
            round_c++;
        }
        else if (Floor_Score.score > 400 && round_c == 5)
        {
            GameObject.FindGameObjectWithTag("bg4").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.17f);
            round_c++;
        }
        else if (Floor_Score.score > 500 && round_c == 6)
        {
            GameObject.FindGameObjectWithTag("bg5").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.15f);
            round_c++;
        }
        else if (Floor_Score.score > 600 && round_c == 7)
        {
            GameObject.FindGameObjectWithTag("bg6").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.12f);
            round_c++;
        }
        else if (Floor_Score.score > 700 && round_c == 7)
        {
            GameObject.FindGameObjectWithTag("bg7").SetActive(false);
            CancelInvoke("CreateObjects");
            InvokeRepeating("CreateObjects", 1f, 0.08f);
            round_c++;
        }
    }
}
