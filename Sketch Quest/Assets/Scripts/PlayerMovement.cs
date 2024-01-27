using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public PlayerInput pInput;
    public float speed = 6f;
    // Update is called once per frame

    void Update()
    {
        Vector2 movement = pInput.actions["Move"].ReadValue<Vector2>();
        Vector3 direction = new Vector3(movement.x, 0f, movement.y).normalized;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
