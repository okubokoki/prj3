using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayController : MonoBehaviour
{
    public GameObject buttonCollider;
    public GameObject PlayerCamera;
    GameObject[] difficultyImages;
    public GameObject ui;
    public Image lookGaugeImage;
    float lookGaugeSpeed = 0.02f;

    void Start()
    {
        difficultyImages = GameObject.FindGameObjectsWithTag("DifficultyImage");
    }

    void Update()
    {
        Ray ray = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.black);
            if (hit.collider.gameObject.tag == "DifficultyCollider")
            {
                for (int i = 0; i < difficultyImages.Length; i++)
                {
                    difficultyImages[i].GetComponent<Image>().color = Color.white;
                }
                hit.collider.gameObject.transform.parent.GetComponent<Image>().color = Color.red;
            }
            if (hit.collider.gameObject == buttonCollider)
            {
                ui.SetActive(false);
            }

        }
        }
}