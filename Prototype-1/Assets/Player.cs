using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(hor * speed * Time.deltaTime, 0, vert * speed * Time.deltaTime);
        rb.AddForce(move * speed * Time.deltaTime);
    }
}
