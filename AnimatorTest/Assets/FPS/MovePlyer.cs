using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlyer : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody PlyerRb = default;
    private float DirX, DirY;
    private Animator PlyerAnimator = default;
    private Vector3 Velocity;
    private void Awake()
    {
        PlyerRb = GetComponent<Rigidbody>();
        PlyerAnimator = GetComponent<Animator>();
    }

    private void DIR()
    {
        DirX = Input.GetAxis("Horizontal");
        DirY = Input.GetAxis("Vertical");
        Velocity = new Vector3(DirX, 0, DirY);
    }

    private void Move()
    {
        transform.Translate(Velocity*5*Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Mouse X")*5, 0);
    }
   
    void Update()
    {
        DIR();
       Move(); 
    }
}
