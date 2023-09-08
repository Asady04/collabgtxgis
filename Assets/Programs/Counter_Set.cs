using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Counter_Set : MonoBehaviour
{
   public void SetBola()
    {
        PlayerPrefs.SetInt("benda1", 1);
    }
    public void SetLimas()
    {
        PlayerPrefs.SetInt("benda2", 1);
    }
    public void SetKerucut()
    {
        PlayerPrefs.SetInt("benda3", 1);
    }
    public void SetBalok()
    {
        PlayerPrefs.SetInt("benda4", 1);
    }
    public void SetTabung()
    {
        PlayerPrefs.SetInt("benda5", 1);
    }
    public void SetPrisma()
    {
        PlayerPrefs.SetInt("benda6", 1);
    }
    public void SetKubus()
    {
        PlayerPrefs.SetInt("benda7", 1);
    }

    public void Reset()
    {
        for (int i = 1; i <= 7; i++)
        {
            PlayerPrefs.SetInt("benda"+i, 0);
        }
    }
}
