using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
        Time.timeScale = 1f;
    }

    public void Dummy()
    {
        SceneManager.LoadScene("Dummy");
        Time.timeScale = 1f;
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Ended");
    }
}
