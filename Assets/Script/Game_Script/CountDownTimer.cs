using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {


    float startime = 299;
    public Text text;
	// Use this for initialization
	void Start () {
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

        if(text.text == "00:00")
        {
            Debug.Log("Game Over");
        }
	}
}
