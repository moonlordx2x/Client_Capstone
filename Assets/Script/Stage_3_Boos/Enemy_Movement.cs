using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {

    public Transform Werewolf;
    float werewolf_movement = 20f;
    float step;

    int movement_direction = 1;
    bool Player_detect = false;

    Animator animator;
  
    

	// Use this for initialization
	void Start () {
        animator = Werewolf.GetComponent<Animator>();
        step = werewolf_movement * Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {

        if(movement_direction == 1)
        {
            this.gameObject.transform.position += Vector3.left * step;
            this.gameObject.transform.localScale = new Vector2(-1f, 1f);
            animator.SetTrigger("RUNNING");
        }
        else if (movement_direction == 2)
        {
            this.gameObject.transform.position += Vector3.right * step;
            this.gameObject.transform.localScale = new Vector2(1f, 1f);
            animator.SetTrigger("RUNNING");
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Left_Ground")
        {
            movement_direction = 2;
        }
        else if (collision.gameObject.tag == "Right_Ground")
        {
            movement_direction = 1;
        }
    }

 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Tag")
        {
            animator.SetTrigger("ATTACK");
            movement_direction = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Tag")
        {
            movement_direction = 1;
        }
        else if (collision.gameObject.tag == "Left_Ground")
        {
            movement_direction = 2;
        }
        else if (collision.gameObject.tag == "Right_Ground")
        {
            movement_direction = 1;
        }
    }
    
}
