using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float min = 0;
    public float max = 10;
    public float duration = 5.0f;
    float startTime;
    public Rigidbody rb;

    public float thrust = 5f;

    public float yRot;
    public float rotationSpeed;

    Vector3 previousFramePos;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float movementPerFrame = Vector3.Distance(previousFramePos, transform.position);
        float currentSpeed = (movementPerFrame / Time.deltaTime);
        previousFramePos = transform.position;
        PlayerMovement(currentSpeed);
    }

    private void PlayerMovement(float currentSpeed)
    {
        float t = (Time.time - startTime) / duration;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * (Mathf.SmoothStep(min, max, t)));
        

        if (Input.GetKey(KeyCode.A))
        {
            yRot -= 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            yRot += 1;
        }


        transform.eulerAngles = new Vector3(0, yRot * rotationSpeed * Time.deltaTime , 0);
    }
}
