using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public GameObject newImage;
    private int LoadBestScore = 0;
    private static Text bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        bestScoreText = GetComponent<Text>();
        newImage.SetActive(false);

        ///
        if (Score.highScore > PlayerPrefs.GetInt("highScore"))
        {
            newImage.SetActive(true);
            PlayerPrefs.SetInt("highScore", Score.highScore);
        }
        LoadBestScore = PlayerPrefs.GetInt("highScore");

        bestScoreText.text = LoadBestScore.ToString();
    }

}
