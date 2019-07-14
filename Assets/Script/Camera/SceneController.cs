using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{

    public void start()
    {
        SceneManager.LoadScene("Start_Menu");
    }

    public void hidden_object_stage()
    {
        SceneManager.LoadScene("Hidden_Object_Stage_Select");
    }

    public void hidden_object()
    {
        SceneManager.LoadScene("Hidden_Object_1");
    }

    public void hidden_object_2()
    {
        SceneManager.LoadScene("Hidden_Object_2");
    }

    public void hidden_object_3()
    {
        SceneManager.LoadScene("Hidden_Object_3");
    }
}
