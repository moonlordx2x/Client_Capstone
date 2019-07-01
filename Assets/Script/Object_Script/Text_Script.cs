using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Script : MonoBehaviour {

    public static GameObject[] text_object;
    public static GameObject[] hidden_object;

    Text text;

    // Use this for initialization
    void Start () {
        text_object = GameObject.FindGameObjectsWithTag("text_object");
        hidden_object = GameObject.FindGameObjectsWithTag("hidden_object");

        
        for(int i = 0;i < hidden_object.Length; i++)
        {
            GameObject sample_object = hidden_object[i];
            int rand = Random.Range(0, i);
            hidden_object[i] = hidden_object[rand];
            hidden_object[rand] = sample_object;
        }


        for (int i = 0; i < 10; i++)
        {
            text = text_object[i].GetComponentInChildren<Text>();
            text_object[i].name = hidden_object[i].name;
            text.text = "" + hidden_object[i].name;

        }



    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
