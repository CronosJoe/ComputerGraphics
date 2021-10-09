using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void OnQuitButton() 
    {
        //do any clean up needed here
        Application.Quit();
    }
    public void OnPlayButton() 
    {
        SceneManager.LoadScene("MainScene");
    }
    public void OnSettingsButton() 
    {
    //load up whatever settings I want
    }
}
