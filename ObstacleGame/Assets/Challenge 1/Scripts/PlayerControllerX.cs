using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public Rigidbody rb;
   
    private float tiltSpeed = 20.0f;
    private float thrust = 10.0f;
    private float verticalInput;
    public float forwardVel;
    public float turnVel;

  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, forwardVel, ForceMode.Impulse);
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
  
        // move the plane forward at a constant rate 
        rb.AddForce(transform.forward * thrust);
        rb.transform.position += transform.forward * (thrust * Time.deltaTime);
        rb.transform.Rotate(Vector3.right * tiltSpeed * verticalInput * Time.deltaTime);
    }
}
