//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CreateStage : MonoBehaviour
//{
//    int currentTipIndex;
//    [SerializeField]
//    GameObject[] stageTips;
//    [SerializeField]
//    int startTipIndex;
//    [SerializeField]
//    int preInstantiate;
//    [SerializeField]
//    List<GameObject> generatedStageList = new List<GameObject>();



//    [SerializeField]
//    GameObject road1;
//    [SerializeField]
//    GameObject road2;
//    [SerializeField]
//    GameObject[] stages;
//    [SerializeField]
//    GameObject createStage;
//    public GameObject player;
//    [SerializeField]
//    float createStagePosition = 0;
//    [SerializeField]
//    GameObject startstage;
//    [SerializeField]
//    float startStagePosition;

//    // Use this for initialization
//    void Start()
//    {
//        //Instantiate(road1, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
//        createStagePosition += road1.GetComponent<Renderer>().bounds.size.z / 2;
//        print(createStagePosition);

//        currentTipIndex = startTipIndex - 1;
//        UpdateStage(preInstantiate);

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (player.transform.position.z > createStagePosition - 3)
//        {
//            createStage = stages[Random.Range(0, stages.Length)];
//            if (createStage == road1)
//            {
//                createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2;
//                Create();
//            }

//            else if (createStage == road2)
//            {
//                createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2;
//                createStagePosition += 1.5f;

//                Create();
//                createStagePosition -= 1.5f;
//            }

//        }
//    }
//    void Create()
//    {
//        Instantiate(createStage, new Vector3(0.0f, 0.0f, createStagePosition), Quaternion.Euler(0, 90, 0));
//        createStagePosition += createStage.GetComponent<Renderer>().bounds.size.z / 2;
//        generatedStageList.Add(createStage);

//    }

//}
