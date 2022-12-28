using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPipeBelow : MonoBehaviour
{

    public GameObject pipebelow ;

    private BoxCollider2D boxCollider2DPipebelow;
    private void Start()
    {
        boxCollider2DPipebelow = pipebelow.GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        boxCollider2DPipebelow.isTrigger = true;
    }
}
