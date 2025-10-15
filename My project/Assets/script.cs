using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    Public KeyCode Spacebar;

    
public Transform groundCheck; 
public float groundCheckRadius;
 public bool grounded; 
 public LayerMask WhatIsGround;
    public KeyCode L;
    public KeyCode R;

    void Start()
    {
        
    }

  
    void Update()
    {

{


if(Input.GetKeyDown (Spacebar) && grounded){
        
void Jump();}




{
GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
}
        if (Input.GeyKeyDown(Spacebar)) {
            Jump();
        }

        if (Input.GetKeyDown(L)) {
            GetComponent<RigidBody2D>().velocity = new Vector2(- movespeed, GetComponent<RigidBody2D>().velocity.y);
            
if (GetComponent<SpriteRenderer>()!=null)
{
GetComponent<SpriteRenderer>().flipX = true;
}
        }
        

        if (Input.GetKeyDown(R)) {
            GetComponent<RigidBody2D>().velocity = new Vector2(movespeed, GetComponent<RigidBody2D>().velocity.y);
            
            
if (GetComponent<SpriteRenderer>()!=null)
{
GetComponent<SpriteRenderer>().flipX = false;
}
        }

        

GetComponent<SpriteRenderer>().flipX = false;
}



void FixedUpdate()
{
    grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
}



    }

