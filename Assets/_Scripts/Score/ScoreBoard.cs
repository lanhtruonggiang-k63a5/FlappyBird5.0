using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour
{
    public static Text scoreBoardText;
    private int scoreStorage;
    private int counter = 0;

    [SerializeField] private float scoreTime;
    private float timerRun;


    private void Start()
    {
        scoreBoardText = GetComponent<Text>();
        scoreStorage = Score.score;
        StartCoroutine(ScoreIncreasing());
        if (scoreStorage == 0)
        {
            timerRun = 0.7f;
        }
        else
        {
            timerRun = scoreTime / scoreStorage;

        }
    }

    private IEnumerator ScoreIncreasing()
    {
        while (counter < scoreStorage)
        {

            scoreBoardText.text = counter.ToString();
            counter++;
            yield return new WaitForSeconds(timerRun);

        }
        if (counter == scoreStorage)
        {
            scoreBoardText.text = counter.ToString();
            MedalOnBoard.SetMedal(counter);
        }


    }





}
