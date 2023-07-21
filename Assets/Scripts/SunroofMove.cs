using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunroofMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform closedPos;
    [SerializeField] Transform openedPos;
    [SerializeField] public bool isActivated;
    [SerializeField] GameObject top;
    Rigidbody2D rb;

    float posX;
    float posXOpened;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Move();
        posX = top.transform.position.x;
        posXOpened = openedPos.transform.position.x;
    }

    private void Move()
    {
        if (isActivated 
            && (top.transform.position.x > openedPos.transform.position.x))
        {
            top.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (!isActivated 
            && (top.transform.position.x < closedPos.transform.position.x))
        {
            top.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
