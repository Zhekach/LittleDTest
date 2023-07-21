using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] SunroofMove sunroof;
    [SerializeField]bool isActivated;
    SpriteRenderer spr;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isActivated)
        {
            sunroof.isActivated = true;
            spr.color = Color.red;
        }
        else
        {
            sunroof.isActivated = false;
            spr.color = Color.white;
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Item"))
        {
            isActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Item"))
        {
            isActivated = false;
        }
    }
}
