using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //-------------------------------------------------
    //Canvas
    // public GameObject gameOverCanvas;
    // public GameObject readyCanvas;
    public GameObject pipeSpawner;
    // public GameObject startCanvas;
    // public GameObject replayCanvas;
    // public GameObject pauseCanvas;
    // public GameObject goBlack_Canvas;
    // public GameObject goBright_Canvas;
    // //-------------------------------------------------

    //Score
    // public GameObject scoreTop;
    // public GameObject scoreBoardCanvas;
    // public GameObject scoreRecord;
    // public GameObject bestRecord;
    //pause game
    public static bool gameIsPaused;
    //-------------------------------------------------
    //sound
    // [SerializeField] private AudioSource button;
    // [SerializeField] private AudioSource pause;
    // [SerializeField] private AudioSource resume;
    // [SerializeField] private AudioSource death;
    
    // private bool canChopWindPlay ;
    // [SerializeField] private AudioSource chopWind;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        GoBrightAnim.anim.SetBool("goBright", true);
        Time.timeScale =1f;
        if (UIManager.Instance.pauseCanvas != null)
        {
            UIManager.Instance.pauseCanvas.SetActive(true);
        }
        
        // pauseCanvas.SetActive(true);
        gameIsPaused = false;
        // soundManager.CanChopWindPlay = true;
        SoundManager.Instance.CanChopWindPlay = true;
    }
    public void Play()
    {
        UIManager.Instance.readyCanvas.SetActive(false);

        // readyCanvas.SetActive(false);
        pipeSpawner.SetActive(true);
        // SoundManager.Instance.CanPlayChopWindSound();
    }

    public void CallReplayScene(){
        StartCoroutine(ReplayScene());
    }
    
    private IEnumerator ReplayScene(){

        // CanChopWindPlay();
        SoundManager.Instance.CanPlayChopWindSound();
        GoBlackAnim.anim.SetBool("goBlack",true);
        yield return new WaitForSeconds(0.6f);

        SceneManager.LoadScene(0);
    }
    public void LateReady()
    {
        StartCoroutine(LateReadyScene());
    }
    private IEnumerator LateReadyScene()
    {
        // button.Play();
        // CanChopWindPlay();
        SoundManager.Instance.CanPlayChopWindSound();
        GoBlackAnim.anim.SetBool("goBlack", true);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(1);
    }
    private IEnumerator GameOver()
    {
        //Play audio source in inside an IEnumerator make buzzzzzzzzzzzzz sound
        //death.Play();
        

        //appear
        UIManager.Instance.gameOverCanvas.SetActive(true);
        // gameOverCanvas.SetActive(true);
        UIManager.Instance.scoreBoardCanvas.SetActive(true);
        
        // scoreBoardCanvas.SetActive(true);
        
        
        //anim appear
        ScoreBoardAnim.anim.speed = 1f;
        GameOverTextAnim.anim.speed = 1f;
        
        yield return new WaitForSeconds(1f);
        UIManager.Instance.scoreRecord.SetActive(true);
        // scoreRecord.SetActive(true);
        ////////// call here

        UIManager.Instance.bestRecord.SetActive(true);
        // bestRecord.SetActive(true);
        yield return new WaitForSeconds(1f);
        UIManager.Instance.replayCanvas.SetActive(true);
        // replayCanvas.SetActive(true);
    
    }
    public void disappearCanvasGameOver(){
        //disappear
        UIManager.Instance.pauseCanvas.SetActive(false);
        // pauseCanvas.SetActive(false);
        UIManager.Instance.scoreTop.SetActive(false);
        // scoreTop.SetActive(false);
    }
    public void CallGameOver(){
        StartCoroutine(GameOver());
    }
 
    // private void CanChopWindPlay(){
    //     if(canChopWindPlay){
    //         chopWind.Play();
    //         canChopWindPlay=false;
    //     }
    // }
   
   

}