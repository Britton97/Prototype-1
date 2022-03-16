using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float forwardInput;
    public float thrust;
    [SerializeField] GameObject propeller;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Jump");

        transform.Rotate(Vector3.right * speed * verticalInput * Time.deltaTime);
        transform.Rotate(-Vector3.forward * speed * horizontalInput * Time.deltaTime);
        propeller.transform.Rotate(Vector3.forward * (Input.GetAxis("Jump") * 1000) * Time.deltaTime);
        //transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        rb.AddForce(transform.forward * thrust * forwardInput * Time.deltaTime);
    }
}
