using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public static int highScore;
    public static Text scoreText;
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        LoadBestScore();
        scoreText.text = score.ToString();

    }
    void LoadBestScore()
    {
        if (score > highScore)
        {
            highScore = score;
        }


    }
}
