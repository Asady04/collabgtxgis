using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quiz_page : MonoBehaviour
{
    [SerializeField] GameObject prev = null;
    [SerializeField] GameObject next = null;
    [SerializeField] GameObject materi = null;
    [SerializeField] GameObject soal = null;
    public static int page;
    void Start()
    {
        page = 0;
    }

    public void Previous()
    {
        page--;
    }
    public void Next()
    {
        page++;
    }

    void Update()
    {
        switch (page)
        {
            case 0:
                materi.SetActive(true);
                soal.SetActive(false);
                prev.SetActive(false);
                next.SetActive(true);
                break;

            case 1:
                materi.SetActive(false);
                soal.SetActive(true);
                prev.SetActive(true);
                next.SetActive(false);
                break;

            default:
                Debug.Log("Error");
                break;
        }
    }
}
