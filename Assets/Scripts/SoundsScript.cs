using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsScript : MonoBehaviour {
    [SerializeField]
    AudioSource[] sources;
    // Use this for initialization
    void Start () {
        sources = gameObject.GetComponents<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        sources[1].Play();
    }
}
