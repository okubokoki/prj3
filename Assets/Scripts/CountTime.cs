using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTime : MonoBehaviour {
    private float time = 11f;
    public PlayerScript gameOverScript;
    public GameObject policecar;
    public GameObject Player;
    private AudioSource[] sources;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //タイム
        time -= 1f * Time.deltaTime;

        if (time < 0f)
        {
            Instantiate(policecar, new Vector3(Player.transform.position.x, 2f, Player.transform.position.z + 1f), Quaternion.Euler(0f, 0f, 0f));
            GameOver();
        }

    }

     void GameOver ()
     {
          gameOverScript.SendMessage("Lose");
          Time.timeScale = 0;
          if (Input.GetMouseButtonDown(0))
          {
              Application.LoadLevel("title");
          }
      }
}
