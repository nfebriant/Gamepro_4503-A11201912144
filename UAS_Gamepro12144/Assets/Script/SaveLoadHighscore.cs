using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
    public Text HighScore;
    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = "TOTAL SCORE = " + LoadHighScore().ToString();

    }
    public static int LoadHighScore()
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("TOTAL SCORE"))
            PlayerPrefs.SetInt("TOTAL SCORE", 0);
        else
            hg = PlayerPrefs.GetInt("TOTAL SCORE");
        return hg;
    }
    public static void SaveHighScore(int score)
    {
        int hg = 0;
        if (!PlayerPrefs.HasKey("TOTAL SCORE"))
            PlayerPrefs.SetInt("TOTAL SCORE", 0);
        else
        {
            hg = PlayerPrefs.GetInt("TOTAL SCORE");
            hg += score;
            PlayerPrefs.SetInt("TOTAL SCORE", hg);
        }

    }
}
