using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    float speed;
    //Rigidbody rb;

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody>();
    }

    public Car()
    {
        speed = Random.Range(0.2f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(transform.forward * speed);
        transform.Translate(0f, 0f, speed);
    }
}
