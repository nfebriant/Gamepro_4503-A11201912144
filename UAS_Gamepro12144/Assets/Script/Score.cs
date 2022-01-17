using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;

    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Coin")
        {
            ScoreNum += 15;
            Destroy(Coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
            SaveLoadHighscore.SaveHighScore(ScoreNum);
        }
        
    }
    
}
