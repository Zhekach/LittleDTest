using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamersMove : MonoBehaviour
{

    [SerializeField] Transform playerTr;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 Target = new Vector3()
        {
            x = playerTr.position.x,
            y = playerTr.position.y,
            z = playerTr.position.z - 10
        };
        Vector3 pos = Vector3.Lerp(transform.position, Target, speed * Time.deltaTime);
        transform.position = pos;
    }
}
