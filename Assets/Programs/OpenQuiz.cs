using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenQuiz : MonoBehaviour
{
    [SerializeField] GameObject bola = null;
    [SerializeField] GameObject limas = null;
    [SerializeField] GameObject kerucut = null;
    [SerializeField] GameObject balok = null;
    [SerializeField] GameObject tabung = null;
    [SerializeField] GameObject prisma = null;
    [SerializeField] GameObject kubus = null;
    [SerializeField] GameObject pause = null;
    [SerializeField] GameObject close = null;
    public GameObject gameObject;
    public void Open()
    {
        pause.SetActive(false);
        close.SetActive(true);
        string jenisBangun = gameObject.GetComponent<PlayerMove>().jenisBangun;
        if (jenisBangun == "bola")
        {
            bola.SetActive(true);
        }
        else if (jenisBangun == "limas")
        {
            limas.SetActive(true);
        }
        else if (jenisBangun == "kerucut")
        {
            kerucut.SetActive(true);
        }
        else if (jenisBangun == "balok")
        {
            balok.SetActive(true);
        }
        else if (jenisBangun == "tabung")
        {
            tabung.SetActive(true);
        }
        else if (jenisBangun == "prisma")
        {
            prisma.SetActive(true);
        }
        else if (jenisBangun == "kubus")
        {
            kubus.SetActive(true);
        }
        Time.timeScale = 0;
    }

    public void Close(){
        bola.SetActive(false);
        limas.SetActive(false);
        kerucut.SetActive(false);
        balok.SetActive(false);
        tabung.SetActive(false);
        prisma.SetActive(false);
        kubus.SetActive(false);
        pause.SetActive(true);
        close.SetActive(false);
        Time.timeScale = 1;
    }
}
