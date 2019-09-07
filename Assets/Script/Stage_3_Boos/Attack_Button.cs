using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Button : MonoBehaviour {

    public GameObject Player;
    Animator animator;


	void Start () {
        animator = Player.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Player_Attack_Button()
    {
        animator.SetTrigger("Attack");
        animator.ResetTrigger("Idle");
        animator.ResetTrigger("Running");
    }
}
