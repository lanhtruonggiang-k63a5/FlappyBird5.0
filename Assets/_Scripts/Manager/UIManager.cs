using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }




    //Canvas
    public GameObject gameOverCanvas;
    public GameObject readyCanvas;
    // public GameObject startCanvas;
    public GameObject replayCanvas;
    public GameObject pauseCanvas;
    public GameObject goBlack_Canvas;
    public GameObject goBright_Canvas;

    //Score
    public GameObject scoreTop;
    public GameObject scoreBoardCanvas;
    public GameObject scoreRecord;
    public GameObject bestRecord;




    private void Awake()
    {
        Instance = this;
    }
}
