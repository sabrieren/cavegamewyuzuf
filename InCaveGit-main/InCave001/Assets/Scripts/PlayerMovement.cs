using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public CharacterController2D controller;
   float horizontalMove = 0f;
   public float runSpeed = 40f;
   bool  jump = false;
   bool crouch = false;
   public Animator animator;
   public Rigidbody2D rb;
   public float trampolineForce = 0f;
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Frog")){
            rb.velocity = Vector2.up * trampolineForce;
        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        horizontalMove= Input.GetAxisRaw("Horizontal")* runSpeed;

        if(Input.GetButtonDown("Jump")){
           jump = true;
        }
        
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping",false);
    }
    void FixedUpdate()
    {
    controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
    jump = false;
    }
}
