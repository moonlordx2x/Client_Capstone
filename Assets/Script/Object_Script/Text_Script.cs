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
        /*
        for(int i = 0;i < hidden_object.Length; i++)
        {
            int rand = Random.Range(0, hidden_object.Length);
            hidden_object[i] = hidden_object[rand];
            Debug.Log(hidden_object[i].name);
      
        }

        */
        for (int i = 0; i < 10; i++)
        {
            text = text_object[i].GetComponent<Text>();
            text.text = "" + hidden_object[i].name;
            text_object[i].name = hidden_object[i].name;
        }

        Debug.Log(hidden_object[2].name);
        Debug.Log(text_object[2].name);



    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
