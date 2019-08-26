using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click_Event : MonoBehaviour {

    public static string Click_event_variable;
    public static int object_found;

    Text text;
    Image image;
    Animator animator;
    Animator image_animator;

    Text_Script text_script;

    // Use this for initialization
    void Start()
    {
        object_found = 0;
        text_script = gameObject.GetComponent<Text_Script>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickEvent()
    {
        Click_event_variable = this.gameObject.name.ToString();
        for (int i = 0; i < Text_Script.text_object.Length; i++)
        {
            Debug.Log(Text_Script.text_object[i]);

            if (Text_Script.hint_object[i].activeSelf == false)
            {
                Text_Script.text_object[i].SetActive(false);
            }

            if (Text_Script.text_object[i].activeSelf == false)
            {
                Text_Script.hint_object[i].SetActive(false);
            }


            if (Click_event_variable == Text_Script.hidden_object[i].name)
            {

                //Debug.Log("Object Found " + Text_Script.hidden_object[i].name);
                object_found += 1;
                //Text_Script.text_object[i].SetActive(false);

                if (Hint_Script.hint_cooldown_time == true)
                {
                    image_animator = Text_Script.hint_object[i].GetComponentInChildren<Animator>();
                    image_animator.SetTrigger("Float");
                    Text_Script.text_object[i].SetActive(false);
                }
                else
                {
                    animator = Text_Script.text_object[i].GetComponentInChildren<Animator>();
                    animator.SetTrigger("Float");
                    Text_Script.hint_object[i].SetActive(false);
                }

                //image = Image_Script.hint_object[i].GetComponentInChildren<Image>();
                //image.color = new Color32(178, 84, 52, 255);
                //Image_Script.hint_object[i].SetActive(false);
                this.gameObject.SetActive(false);


            }
            else
            {
                CountDownTimer.startime -= (5 * Time.deltaTime);
                Debug.Log(CountDownTimer.startime);
            }
            //break;
        }
    }

}
