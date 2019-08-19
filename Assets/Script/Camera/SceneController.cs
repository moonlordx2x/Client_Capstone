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

    public void hidden_object_4()
    {
        SceneManager.LoadScene("Hidden_Object_4");
    }

    public void hidden_object_5()
    {
        SceneManager.LoadScene("Hidden_Object_5");
    }


    public void Dodge_Stage_1()
    {
        SceneManager.LoadScene("Dodge_Stage_1");
    }

    public void Dodge_Stage_Select()
    {
        SceneManager.LoadScene("Dodge_Stage_Select");
    }

    public void Main_Stage_Menu()
    {
        SceneManager.LoadScene("Main_Stage_Menu");
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("hidden_object_star_1", 0);
        //PlayerPrefs.SetInt("hidden_object_star_2", 0);
        //PlayerPrefs.SetInt("hidden_object_star_3", 0);
        //PlayerPrefs.SetInt("hidden_object_star_4", 0);
        //PlayerPrefs.SetInt("hidden_object_star_5", 0);
        PlayerPrefs.SetString("hidden_object_1", "Completed");
    }
}
