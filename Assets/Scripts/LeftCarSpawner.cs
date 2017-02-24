using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeftCarSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] cars;
    [SerializeField]
    Transform SpawnPosition;
    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        var car = other.gameObject.GetComponent<Car>();
        if (car == null) return;

        Destroy(car.gameObject);
        var obj = Instantiate<GameObject>(cars[0]);
        obj.transform.localRotation = transform.rotation;
        //+= obj.transform.position;
    }
}
