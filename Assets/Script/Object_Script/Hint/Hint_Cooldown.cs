using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint_Cooldown : MonoBehaviour {

    public Image hint_cooldown;
    float total_cooldown_time = 10;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hint_cooldown.fillAmount -= 1 / total_cooldown_time * Time.deltaTime;

        if (hint_cooldown.fillAmount <= 0)
        {
            hint_cooldown.fillAmount = 1;
            this.gameObject.SetActive(false);
        }
    }
}
