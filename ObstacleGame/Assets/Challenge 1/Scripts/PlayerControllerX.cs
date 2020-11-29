using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float thrust = 1.0f;
    private float rotationSpeed = 45.0f;
    private float verticalInput;
    private float horizontalInput;
    private float forwardInput;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        rb.AddForce(transform.forward * thrust);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * verticalInput * Time.deltaTime);
       // transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
