using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay1 : MonoBehaviour
{
    public Animator animator;
    private void Start()
    {
        //animator = GetComponent<Animator>();
    }
    public void playAny(bool isplay)
    {
        animator.SetBool("Play", isplay);
    }
}
