using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Variables
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;
    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //Checks to see if groundCheck and ground Layer are colliding within an invisible sphere
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //If statement that creates strong gravity
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Floats for x and z axis movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Vector for movement
        Vector3 move = transform.right * x + transform.forward * z;

        //Jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        //Movement adapted into Character Controller
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
}