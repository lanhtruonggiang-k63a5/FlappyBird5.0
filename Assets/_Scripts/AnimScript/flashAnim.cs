using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashAnim : MonoBehaviour
{
    public static Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();

    }

}
