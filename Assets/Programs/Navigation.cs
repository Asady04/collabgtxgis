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

    public void Map()
    {
        SceneManager.LoadScene("Map");
        Time.timeScale = 1f;
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1f;
    }

    public void ARbalok()
    {
        SceneManager.LoadScene("ARblock");
        Time.timeScale = 1f;
    }
    public void ARkubus()
    {
        SceneManager.LoadScene("ARcube");
        Time.timeScale = 1f;
    }
    // public void ARbola()
    // {
    //     SceneManager.LoadScene("Credits");
    //     Time.timeScale = 1f;
    // }
    // public void ARkerucut()
    // {
    //     SceneManager.LoadScene("Credits");
    //     Time.timeScale = 1f;
    // }
    // public void ARlimas()
    // {
    //     SceneManager.LoadScene("Credits");
    //     Time.timeScale = 1f;
    // }
    public void ARprisma()
    {
        SceneManager.LoadScene("ARprism");
        Time.timeScale = 1f;
    }
    public void ARtabung()
    {
        SceneManager.LoadScene("ARcyl");
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Ended");
    }
}
