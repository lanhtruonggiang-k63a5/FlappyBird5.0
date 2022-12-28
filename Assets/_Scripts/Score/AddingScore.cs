using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingScore : MonoBehaviour
{
    // [SerializeField] private AudioClip scored ;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // AudioSource.PlayClipAtPoint(scored,new Vector3(0,0,0));
        SoundManager.Instance.CanPlayScoreSound();
        Score.score+=1;

    }
    
}
