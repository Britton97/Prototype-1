using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public float speed;
    [SerializeField] public float radius;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(speed - .25f, speed + .25f);
        radius = Random.Range(radius - 5, radius + 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < radius)
        {
            Vector3 direction = transform.position - player.transform.position;
            transform.position -= direction * speed * Time.deltaTime;
        }
    }
}
