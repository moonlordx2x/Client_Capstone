using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Event : MonoBehaviour {

    public static string Click_event_variable;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickEvent()
    {
        Click_event_variable = this.gameObject.name.ToString();

        for (int i = 0; i < Text_Script.text_object.Length; i++)
        {
            if (Click_event_variable == Text_Script.hidden_object[i].name)
            {
                Debug.Log("Object Found " + Text_Script.hidden_object[i].name);
                Text_Script.text_object[i].SetActive(false);
                this.gameObject.SetActive(false);
                break;
            }

        }
    }

}
