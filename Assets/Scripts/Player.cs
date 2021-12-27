using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 1;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate() // runs ONCE AT THE START
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);

        //Debug.Log("horizontal: " + moveX);
        //Debug.Log("vertical: " + moveY);
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * MovementSpeed, moveDirection.y * MovementSpeed);

        if (moveDirection.x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else if (moveDirection.x > 0)
            transform.localScale = Vector3.one;
    }

}