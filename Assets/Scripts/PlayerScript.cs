using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;



public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    [SerializeField]
    GameObject GameStart;

    void Start()
    {
        GameStart.gameObject.GetComponent<Image>().enabled = true;
        GameOver.gameObject.GetComponent<Image>().enabled = false;
    }


    void OnTriggerEnter(Collider other)
    {
        Lose();
    }

    public void Lose()
    {
        GameOver.gameObject.GetComponent<Image>().enabled = true;
        Time.timeScale = 0f;

        //// 現在のシーン番号を取得
        //int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        //// 現在のシーンを再読込する
        //SceneManager.LoadScene(sceneIndex);
    }
}