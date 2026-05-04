using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementNEW : MonoBehaviour
{
    [SerializeField] public float speed = 5f;
    public Animator anim;
    public SpriteRenderer sprite; 

    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 movement = Vector3.zero;
        var keyboard = Keyboard.current;

        if (keyboard != null)
        {
            
            if (keyboard.dKey.isPressed) movement.x += 1;
            if (keyboard.aKey.isPressed) movement.x -= 1;
            if (keyboard.wKey.isPressed) movement.y += 1;
            if (keyboard.sKey.isPressed) movement.y -= 1;

           
            transform.position += movement.normalized * speed * Time.deltaTime;

            
            
            // Animator Parameters
            if (anim != null)
            {
                bool isMoving = movement.magnitude > 0;
                
                // tells the Animator to switch between Idle and Move states
                anim.SetBool("isMoving", isMoving);

                // tell the Blend Tree which direction to play
                anim.SetFloat("moveX", movement.x);
                anim.SetFloat("moveY", movement.y);
            
            
            
                if (keyboard.dKey.isPressed) anim.Play("right");
                else if (keyboard.aKey.isPressed) anim.Play("left");
                else if (keyboard.wKey.isPressed) anim.Play("up");
                else if (keyboard.sKey.isPressed) anim.Play("Down");
                else anim.Play("idle");
           }
            
        }
    }
}