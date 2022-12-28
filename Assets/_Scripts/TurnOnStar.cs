using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnStar : MonoBehaviour
{
    private new ParticleSystem particleSystem;

    
    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Pause();
    }
    
    private void Update()
    {
        if(MedalOnBoard.isSparkle == true){
            particleSystem.Play();
        }
    }
}
