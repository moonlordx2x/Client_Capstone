using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Game : MonoBehaviour {


    public float start;
    public float deduction;
    public GameObject Counter;
    // Use this for initialization
    void Start () {
        Counter.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        start -= deduction * Time.deltaTime;
        if (start <=0)
        {
            this.gameObject.SetActive(false);
            Counter.SetActive(true);
            CountDownTimer.startime = 299f;
        }
	}
}
