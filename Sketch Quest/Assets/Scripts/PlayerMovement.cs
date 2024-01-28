using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public PlayerInput pInput;
    public float speed = 3f;


    private Animator animator;

    void Start() 
    {
       animator = GetComponent<Animator>(); 
    }
    
    void Update()
    {
        Vector2 movement = pInput.actions["Move"].ReadValue<Vector2>();
        Vector3 direction = new Vector3(movement.x, 0f, movement.y).normalized;

        

        if (movement.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);

            //character facing direction
            Vector3 lookDirection = direction + gameObject.transform.position;
            gameObject.transform.LookAt(lookDirection);
        }

        if(movement == Vector2.zero)
        {
            animator.SetFloat("Speed",0);
        }
        else
        {
            animator.SetFloat("Speed", 1f);
        }

    }
}
