using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    
    Vector3 input;
    public bool isGrounded;
    public bool isResistedFront;
    public bool isResistedBack;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), 0);
        if(input.x > 0 && isResistedFront)
        {
            input.x = 0;
        }
        if (input.x < 0 && isResistedBack)
        {
            input.x = 0;
        }
        transform.position += input * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
}
