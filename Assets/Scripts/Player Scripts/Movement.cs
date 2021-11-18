using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 50f;
    public Vector2 turn;

    void Update()
    {
        //Obracanie myszk¹
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0, -turn.y, 0);


        //Sterowanie WSAD
        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.right;

        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.left;

        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.forward;

        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _moveSpeed * Vector3.back;

        //Chwilowo nieu¿ywane
        //if (Input.GetKeyDown(KeyCode.Space))
        //   transform.position = new Vector3(0, 0.5f, 0);
    }
}
