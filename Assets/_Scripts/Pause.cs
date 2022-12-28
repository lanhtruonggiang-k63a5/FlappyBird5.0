using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pause : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Image img;
    //pause-resume sound
    // public AudioSource pauseSound;
    // public AudioSource resumeSound;
    public Sprite pause;
    public Sprite resume;

    public static int clickState = 1;
    public static bool releaseResume;
    public static int onPause = 0;




    private void Start()
    {
        img = GetComponent<Image>();
        releaseResume = true;
        onPause = 0;

    }
    public void OnPointerDown(PointerEventData eventData)
    {

        releaseResume = false;
        OnPauseGame();
    }
    public void OnPointerUp(PointerEventData eventData)
    {

        releaseResume = true;
        clickState = 1;

    }

    public void OnPauseGame()
    {
        if (GameManager.gameIsPaused == false)
        {
            clickState = 2;
            onPause = 1;
            img.sprite = resume;
            // pauseSound.Play();
            SoundManager.Instance.PlayChopWindSound();
            Time.timeScale = 0f;
            GameManager.gameIsPaused = true;
        }
        else
        {
            clickState = 3;
            onPause = 2;

            Time.timeScale = 1f;
            // resumeSound.Play();
            SoundManager.Instance.PlayChopWindSound();

            img.sprite = pause;
            GameManager.gameIsPaused = false;
        }
    }


}
