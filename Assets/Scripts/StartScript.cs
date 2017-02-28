using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{

    float time = 0f;

    [SerializeField] Text _textCountdown;


    // Use this for initialization
    void Start()
    {
        time = 0f;
        SceneManager.sceneLoaded += OnSceneLoaded;//イベントにメソッドを登録

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 5f)
        {
            Destroy(this.gameObject);
            StartCoroutine(CountdownCoroutine());
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
        time += Time.deltaTime;

        if (time > 3f)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator CountdownCoroutine()
    {
        _textCountdown.gameObject.SetActive(true);

        _textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);

        _textCountdown.text = "2";
        yield return new WaitForSeconds(1.0f);

        _textCountdown.text = "1";
        yield return new WaitForSeconds(1.0f);

        _textCountdown.text = "GO!";
        yield return new WaitForSeconds(1.0f);

        _textCountdown.text = "";
        _textCountdown.gameObject.SetActive(false);



    }
}