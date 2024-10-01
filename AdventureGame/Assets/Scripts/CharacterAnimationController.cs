using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
   private Animator animator;


        private void Start()
    {
        // Cache the Animator component attached to CharacterArt
        animator= GetComponent<Animator>();
    }


    private void Update()
    {
        HandleAnimations();
    }



    private void HandleAnimations()
    {
      

        // Handle Double Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(name: "DoubleJumpTrigger");
        }

        // Handle Fall
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger(name: "FallTrigger");
        }

        // Handle Hit
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger(name: "HitTrigger");
        }
    }
}
