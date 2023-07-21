using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTrigger : MonoBehaviour
{
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] GameObject frontCheck;
    [SerializeField] GameObject backCheck;
    [SerializeField] float groundRadius = 0.2f;

    private void Update()
    {
        GetComponent<PlayerController>().isResistedFront = Physics2D.OverlapCircle(frontCheck.transform.position, groundRadius, whatIsGround);
        GetComponent<PlayerController>().isResistedBack = Physics2D.OverlapCircle(backCheck.transform.position, groundRadius, whatIsGround);
    }
}
