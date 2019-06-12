using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour {


    public GameObject hidden_object;
    public GameObject text_object;
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject pause_menu;

    void Start () {
        Time.timeScale = 1f;
        pause_menu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void launchPauseMenu()
    {
        hidden_object.SetActive(false);
        text_object.SetActive(false);
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
        object4.SetActive(false);
        pause_menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void closePauseMenu()
    {
        Time.timeScale = 1f;
        hidden_object.SetActive(true);
        text_object.SetActive(true);
        object1.SetActive(true);
        object2.SetActive(true);
        object3.SetActive(true);
        object4.SetActive(true);
        pause_menu.SetActive(false);
    }
}
