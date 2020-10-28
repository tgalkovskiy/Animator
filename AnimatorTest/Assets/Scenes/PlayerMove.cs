using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject Shot1;
    [SerializeField] private float Speed;
    private Vector2 Velocity;
    private Animator MainAnimator;
    private SpriteRenderer MainSpriterender;
    private Rigidbody2D MainRb2D;
    private bool isGround;
    private int Walk = Animator.StringToHash("Walk");
    private int Run = Animator.StringToHash("Run");
    private int Jump = Animator.StringToHash("Jump");
    private void Awake()
    {
        MainAnimator = GetComponent<Animator>();
        MainSpriterender = GetComponent<SpriteRenderer>();
        MainRb2D = GetComponent<Rigidbody2D>();
    }
    
    private void Move()
    {
        var Dir = Input.GetAxis("Horizontal");
        if (Dir > 0)
        {
            MainSpriterender.flipX = false;
        }
        else if (Dir < 0)
        {
            MainSpriterender.flipX = true;
        }
        if (Mathf.Abs(Dir) > 0.1f)
        {
            MainAnimator.SetBool(Walk, true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                MainAnimator.SetBool(Run, true);
            }
            else
            {
                MainAnimator.SetBool(Run, false);
            }
        }
        else
        {
            MainAnimator.SetBool(Walk, false);
        }
        transform.Translate(Vector3.right*Dir*Speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MainRb2D.AddForce(Vector2.up*15000*Time.deltaTime);
            MainAnimator.SetBool(Jump, true);
        }
    }
    void Update()
    {
      Move();
      
    }
    
}
