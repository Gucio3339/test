using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Rotate : MonoBehaviour
{
    public Vector2 turn;

    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0, -turn.y, 0);
    }
}
