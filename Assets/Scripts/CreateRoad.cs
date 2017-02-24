using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoad : MonoBehaviour {

    [SerializeField]
    GameObject road1;
    [SerializeField]
    GameObject road2;
    [SerializeField]
    GameObject[] stages;
    [SerializeField]
    GameObject createStage;
    public GameObject player;
    [SerializeField] int createCount = 0;
    [SerializeField] GameObject oldStage;
    [SerializeField] float createStagePosition = 0;
    [SerializeField] GameObject startstage;
    [SerializeField] float startStagePosition;

    // Use this for initialization
    void Start () {
        stages = new GameObject[] { road1, road2, };
        startStagePosition = road1.GetComponent<Renderer>().bounds.size.z / 2;
        oldStage = startstage;
    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.z > createStagePosition - 5)
        {
            createStage = stages[Random.Range(0, stages.Length)];
            if (createCount == 0)
            {
                createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2 + startstage.GetComponent<Renderer>().bounds.size.z / 2;
            }
            else if (createCount > 1)
            {
                createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2 + oldStage.GetComponent<Renderer>().bounds.size.z / 2;
            }
            oldStage = createStage;
            createCount += 1;
            Create();
        }
    }
    void Create()
    {
        Instantiate(createStage, new Vector3(0.0f, 0.0f, createStagePosition), Quaternion.Euler(0, 90, 0));
        createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2 + oldStage.GetComponent<Renderer>().bounds.size.z;
    }

}
