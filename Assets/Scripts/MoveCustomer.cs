using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCustomer : MonoBehaviour
{
    Vector3 target = new Vector3(500, 383, 0); //x좌표 y좌표

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 1.2f);
    }
}
