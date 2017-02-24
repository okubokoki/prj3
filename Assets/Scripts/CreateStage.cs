using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreateStage : MonoBehaviour
{
    [SerializeField]
    GameObject road1;
    [SerializeField]
    GameObject road2;
    [SerializeField]
    GameObject road3;
    [SerializeField]
    GameObject road4;
    [SerializeField]
    GameObject road5;
    [SerializeField]
    GameObject road6;
    GameObject[] stages;
    GameObject createStage;
    public GameObject player;
    public GameObject enemy;
    float createStagePosition = 0;
    // Use this for initialization
    void Start()
    {
        stages = new GameObject[] { road1, road2, };
        if (/*player.transform.position.z > createStagePosition - 1 && */player.transform.position.z == 0)
        {
            print("aaa");
            createStage = stages[Random.Range(0, stages.Length)];
            createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2;
            Create();
        }
    }
    // Update is called once per frame
    void Update()
    {
       
        if(player.transform.position.z > createStagePosition - 1)
        {
            print("bbb");
            createStage = stages[Random.Range(0, stages.Length)];
            createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2;
            Create();
        }

    }
    void Create()
    {
        Instantiate(createStage, new Vector3(0.0f, 0.0f, createStagePosition), Quaternion.Euler(0, 90, 0));
        createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2;
    }
}