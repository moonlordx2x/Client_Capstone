﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Controller : MonoBehaviour {

    private float speed = 50f;
    private float movement = 0f;
    public Animator animate;
    public Rigidbody2D Rigidbody2D;
    public GameObject Game_over;


    // Use this for initialization
    void Start() {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
        Game_over.SetActive(false);

    }

    // Update is called once per frame
    void Update() {
        movement = CrossPlatformInputManager.GetAxis("Horizontal");
        Rigidbody2D.velocity = new Vector2(speed * movement, Rigidbody2D.velocity.y);

        if (movement < 0 || Input.GetKey("a")) { transform.localScale = new Vector2(-1f, 1f);
            animate.SetTrigger("Running");
        }
        else if (movement > 0 || Input.GetKey("d")) { transform.localScale = new Vector2(1f, 1f);
            animate.SetTrigger("Running");
        }
        else {
            Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y);
            animate.SetTrigger("Idle");
        }
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Falling_Object")
        {
            Game_over.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
