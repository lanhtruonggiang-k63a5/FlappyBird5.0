using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardAnim : MonoBehaviour
{
    public static Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
}
