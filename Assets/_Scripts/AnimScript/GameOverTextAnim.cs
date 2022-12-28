using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTextAnim : MonoBehaviour
{
    public static Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
}
