using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRight : MonoBehaviour
{
    float speed;
    //Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    public CarRight()
    {
        speed = Random.Range(0.1f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(transform.forward * speed);
        transform.Translate(0f, 0f, -speed);
    }
}
