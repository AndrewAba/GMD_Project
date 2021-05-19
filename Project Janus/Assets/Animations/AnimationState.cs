using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour
{
    Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isCrouched = animator.GetBool("crouch");
        bool isRunning = animator.GetBool("run");
        bool walk = animator.GetBool("walk");
        bool walkl = animator.GetBool("walkl");
        bool walkr = animator.GetBool("walkr");
        bool crouchPressed = Input.GetKey(KeyCode.LeftControl);
        bool runPressed = Input.GetKey("left shift");
        bool forwardWalk = Input.GetKey("w");
        bool leftWalk = Input.GetKey("a");
        bool rightWalk = Input.GetKey("d");

        if (!walk && forwardWalk)
        {
            animator.SetBool("walk", true);
        }

        if (walk && !forwardWalk)
        {
            animator.SetBool("walk", false);
        }

        if (!walkl && leftWalk)
        {
            animator.SetBool("walkl", true);
        }

        if (walkl && !leftWalk)
        {
            animator.SetBool("walkl", false);
        }

        if (!walkr && rightWalk)
            {
                animator.SetBool("walkr", true);
            }

        if (walkr && !rightWalk)
        {
            animator.SetBool("walkr", false);
        }

        if (!isRunning && (forwardWalk && runPressed))
        {
            animator.SetBool("run", true);
        }

        if (isRunning && (!forwardWalk || !runPressed))
        {
            animator.SetBool("run", false);
        }

        if(!isCrouched && crouchPressed)
        {
            animator.SetBool("crouch", true);
        }

        if (isCrouched && !crouchPressed)
        {
            animator.SetBool("crouch", false);
        }

        if (isCrouched && forwardWalk)
        {
            animator.SetBool("forwardFromCrouch", true);
        }

        if (!isCrouched || !forwardWalk)
        {
            animator.SetBool("forwardFromCrouch", false);
        }

        if (walk && crouchPressed)
        {
            animator.SetBool("walkToCrouch", true);
        }

        if (!walk || crouchPressed)
        {
            animator.SetBool("walkToCrouch", false);
        }

    }
}
