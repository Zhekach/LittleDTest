using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundRadius = 0.2f;

    private void Update()
    {
        GetComponent<PlayerController>().isGrounded = Physics2D.OverlapCircle(groundCheck.transform.position, groundRadius, whatIsGround);
    }

}
