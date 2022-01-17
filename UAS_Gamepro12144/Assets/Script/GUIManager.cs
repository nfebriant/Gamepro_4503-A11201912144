using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;


public class GUIManager : MonoBehaviour
{
    public GameObject TombolPause;
    // Start is called before the first frame update

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void OnPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnCredits()
    {
        SceneManager.LoadScene("Credit");
    }
    public void OnHelp()
    {
        SceneManager.LoadScene("Help");
    }
    public void OnBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PauseControl()
    {
        if(Time.timeScale == 1)
        {
            TombolPause.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            TombolPause.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public static int LoadLevel()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("highscore"))
            PlayerPrefs.SetInt("highscore", 0);
        else
            hg = PlayerPrefs.GetInt("highscore");
        return hg;
    }
}    
