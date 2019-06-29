using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

    public GameObject Success;
    public GameObject Game_over;
    public GameObject hidden_object;
    public GameObject hint_button;
    public GameObject hint_text;
    public GameObject hint_cooldown;
    public GameObject text_object;
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject pause_menu;
    public static float startime = 309f;
    public static int total_star = 0;
    public Text text;
	// Use this for initialization
	void Start () {
        Game_over.SetActive(false);
        Success.SetActive(false);
        StartCoundownTimer();
    }
    
    void StartCoundownTimer()
    {
        if (text != null)
        {
            text.text = "Time Left: 20:00:000";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }


    void UpdateTimer()
    {
        if (text != null)
        {
            startime -= Time.deltaTime;
            string minutes = Mathf.Floor(startime / 60).ToString("00");
            string seconds = (startime % 60).ToString("00");
            text.text = minutes + ":" + seconds;
        }
    }
   

    // Update is called once per frame
    void Update () {
        if (startime >= 201f)
        {
            total_star = 3;
        }
        else if(startime >= 101f && startime <= 200f)
        {
            total_star = 2;
        }
        else
        {
            total_star = 1;
        }

        if (Click_Event.object_found == 10)
        {
            Success.SetActive(true);
            Game_over.SetActive(false);
            hidden_object.SetActive(false);
            hint_button.SetActive(false);
            hint_text.SetActive(false);
            hint_cooldown.SetActive(false);
            text_object.SetActive(false);
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(false);
            pause_menu.SetActive(false);
        }
      


        if (text.text == "00:00")
        {

            Game_over.SetActive(true);
            hidden_object.SetActive(false);
            hint_button.SetActive(false);
            hint_text.SetActive(false);
            hint_cooldown.SetActive(false);
            text_object.SetActive(false);
            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(false);
            pause_menu.SetActive(false);
            Time.timeScale = 0f;
        }
	}
}
