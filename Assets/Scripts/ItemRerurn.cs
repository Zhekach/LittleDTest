using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRerurn : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] float itemRadius;
    bool itemDeleted = false;
    SpriteRenderer spr;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        ReturnItemCheck();
    }

    private void ReturnItemCheck()
    {
        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            && itemRadius >= Vector3.Distance(transform.position, item.transform.position)
            && !itemDeleted)
        {
            ReturnItemStart();
        }

        if ((Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
            && itemDeleted)
        {
            ReturnItemFinish();
        }
    }

    private void ReturnItemStart()
    {
        spr.color = Color.blue;
        Destroy(item);
        itemDeleted = true;
    }
    private void ReturnItemFinish()
    {
        spr.color = Color.white;
        //item = Instantiate(itemPrefab, transform.position, Quaternion.identity);   //интересная механика появления) получилось случайно
        item = Instantiate(itemPrefab, new Vector3
            (transform.position.x + 2,
            transform.position.y + 1,
            0)
            , Quaternion.identity);
        itemDeleted = false;
    }

}
