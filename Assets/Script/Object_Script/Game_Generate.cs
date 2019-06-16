using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Generate : MonoBehaviour {

    public Image loading;
    public GameObject hint_object;
    public GameObject text_object;
    public GameObject loading_object;
    float timer = 0.20f;
	// Use this for initialization
	void Start () {
        text_object.SetActive(true);
        loading_object.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {


        loading.fillAmount += timer * Time.deltaTime;
        hint_object.SetActive(true);
        if (loading.fillAmount >= 1)
        {
            hint_object.SetActive(false);
            loading_object.SetActive(false);
            text_object.SetActive(true);
        }

    }
}
