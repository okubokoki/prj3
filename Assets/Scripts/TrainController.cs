using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour {

    public float timeOut;
    private float timeElapsed;
    [SerializeField]
    GameObject[] trains;
    [SerializeField]
    GameObject SpawnPosition;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // Do anything
            var obj = Instantiate(trains[0], SpawnPosition.transform.position, Quaternion.Euler(0f, 90f, 0f));
            timeElapsed = 0.0f;
        }
    }

    void OnCollisionExit(Collision other)
    {
        var train = other.gameObject.GetComponent<Train>();
        //if (train == null) return;

        Destroy(train.gameObject);
        //var obj = Instantiate<GameObject>(trains[0]);
        
            //var obj = Instantiate(trains[0], SpawnPosition.transform.position, Quaternion.Euler(0f, 90f, 0f));
        
        //obj.transform.localRotation = transform.rotation;
    }
}
