using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainRight : MonoBehaviour
{

    float trainspeed = Random.Range(0.8f, 1);

    // Use this for initialization
    void Start()
    {

    }

    public TrainRight()
    {
        float trainspeed = Random.Range(1, 3);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(0, 0, -trainspeed);
        transform.Translate(p);
    }
}
