using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint_Script : MonoBehaviour {


    public GameObject hint_cooldown;
    public GameObject hint_object;
    public GameObject text_object;

    float hint_time = 5f;
    bool hint_display = false;

    void Start () {
        hint_cooldown.SetActive(false);
        hint_object.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if(hint_display == true)
        {
            hint_time -= Time.deltaTime;

            if(hint_time <= 0)
            {
                hint_object.SetActive(false);
                text_object.SetActive(true);
                hint_display = false;
                hint_time = 5f;
            }
        }
    }

    public void hint_click()
    {
        if(Hint_text.total_hint >= 1)
        {
            Debug.Log("Clicked");
            hint_cooldown.SetActive(true);
            hint_object.SetActive(true);
            text_object.SetActive(false);
            Hint_text.total_hint -= 1;

            hint_display = true;


        }
        
    }
}
