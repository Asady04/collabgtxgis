using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public float x,y,z;
    void Start()
    {
       x = PlayerPrefs.GetFloat("x",0);
       y = PlayerPrefs.GetFloat("y",0);
       z = PlayerPrefs.GetFloat("z",0);

       Vector3 LoadPosition = new Vector3(x,y,z);
       transform.position = LoadPosition;
    }

    public void Save()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }
}
