using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Controller : MonoBehaviour {

    private float speed = 40f;
    private float movement = 0f;
    public Animator animate;
    public Rigidbody2D Rigidbody2D;


    // Use this for initialization
    void Start() {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {
        movement = CrossPlatformInputManager.GetAxis("Horizontal");
        Rigidbody2D.velocity = new Vector2(speed * movement, Rigidbody2D.velocity.y);

        Debug.Log(movement);

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
}
