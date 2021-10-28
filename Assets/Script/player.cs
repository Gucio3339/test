using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sterowanie WSAD
public class player : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))

            rb.AddForce(Vector3.forward * 20);

        if (Input.GetKey(KeyCode.S))

            rb.AddForce(Vector3.back * 20);

        if (Input.GetKey(KeyCode.A))

            rb.AddForce(Vector3.left * 20);

        if (Input.GetKey(KeyCode.D))

            rb.AddForce(Vector3.right * 20);
    }
}
