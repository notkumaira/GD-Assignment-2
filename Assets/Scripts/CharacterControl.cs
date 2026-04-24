using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class Charactercontrol : MonoBehaviour
{
        public Animator anim;

        public float moveSpeed;
      
        public Rigidbody2D rb;

        public float x;
        public float y;
        
        public Vector2 input;
        public bool moving;

     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Animate();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = input * moveSpeed;
    }

    void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        input = new Vector2(x, y);
        input.Normalize(); 
    }  
    void Animate()
    {
        if(input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            moving = true;
        }
        else 
        {
            moving = false;
        }
        if(moving)
        {
            anim.SetFloat("X",x);
            anim.SetFloat("Y",y);
        }
        anim.SetBool("Moving", moving);

    }  
}
