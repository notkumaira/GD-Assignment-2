using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementNEW : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Animator anim;
    private SpriteRenderer sprite; 

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

            
            
            // 4. Update Animator Parameters
            if (anim != null)
            {
                bool isMoving = movement.magnitude > 0;
                
                // tells the Animator to switch between Idle and Move states
                anim.SetBool("moving", isMoving);

                // tell the Blend Tree which direction to play
                anim.SetFloat("X", movement.x);
                anim.SetFloat("Y", movement.y);
            }
        }
    }
}