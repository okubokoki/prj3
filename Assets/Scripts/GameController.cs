using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController: MonoBehaviour {

    [SerializeField]
    Text scoreLabel;
    int score;
    GameObject[] enemies;
    [SerializeField] GameObject enemy;
    float stageWidth;
    float stageHeight;

    // Use this for initialization
    void Start () {
        score = 0;	
	}

    // Update is called once per frame
    void Update()
    {

        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length < 5)
        {
            Instantiate(enemy, new Vector3(Random.Range(-stageWidth / 2, stageWidth / 2), 1,
            Random.Range(-stageHeight / 2, stageHeight / 2)), Quaternion.identity);

            //スコアラベルを更新
            scoreLabel.text = "Score: " + score;
        }
    }

    public void ScorePlus()
    {
        score += 100;
    }
}
