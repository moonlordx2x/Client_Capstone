using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Line : MonoBehaviour
{

    public GameObject Success_menu;

    // Use this for initialization
    void Start()
    {
        Success_menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player_Tag")
        {
            Success_menu.SetActive(true);
            Time.timeScale = 0f;
        }

    }

}
