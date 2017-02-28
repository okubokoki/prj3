using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour {

    float trainspeed = Random.Range(0.6f, 1);

    // Use this for initialization
    void Start () {
		
	}
	
    //public Train()
    //{
    //    float trainspeed = Random.Range(1,3);
    //}
	// Update is called once per frame
	void Update () {
        Vector3 p = new Vector3(0, 0, trainspeed);
        transform.Translate(p);
    }
}
