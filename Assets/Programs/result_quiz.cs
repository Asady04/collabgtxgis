using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result_quiz : MonoBehaviour
{
    [SerializeField] GameObject button = null;
    [SerializeField] GameObject scanButton = null;
    public void Correct()
    {
        button.GetComponent<Image>().color = Color.green;
        scanButton.SetActive(true);
    }

    public void Wrong()
    {
        button.GetComponent<Image>().color = Color.red;
    }
}
