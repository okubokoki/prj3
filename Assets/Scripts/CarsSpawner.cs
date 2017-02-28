using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarsSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] cars;
    [SerializeField]
    GameObject SpawnPosition;

    private void Start()
    {
        Instantiate(cars[0], SpawnPosition.transform.position, Quaternion.Euler(0f, 90f, 0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        var car = other.gameObject.GetComponent<Car>();
        //        if (car == null) return;
        car.transform.position = SpawnPosition.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //void OnCollisionEnter(Collision other)
    //{
    //    print("atattayo");
    //    var car = other.gameObject.GetComponent<Car>();
    //        if (car == null) return;

    //    //Destroy(car.gameObject);
    //    //car = null;
    //    //var obj = Instantiate(car);
    //    //var obj = Instantiate(cars[0], SpawnPosition.transform.position, Quaternion.Euler(0f, 90f, 0f));
        
    //    car.transform.position = SpawnPosition.transform.position; 
       
    //    //Instantiate<GameObject>(cars[0]);
    //        //obj.transform.localRotation = transform.rotation;
    //        //obj.transform.forward = transform.forward;

    //}
}
