using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Counter : MonoBehaviour
{
    [SerializeField] Button bola = null;
    [SerializeField] Button limas = null;
    [SerializeField] Button kerucut = null;
    [SerializeField] Button balok = null;
    [SerializeField] Button tabung = null;
    [SerializeField] Button prisma = null;
    [SerializeField] Button kubus = null;
    [SerializeField] GameObject imageBola = null;
    [SerializeField] GameObject imageLimas = null;
    [SerializeField] GameObject imageKerucut = null;
    [SerializeField] GameObject imageBalok = null;
    [SerializeField] GameObject imageTabung = null;
    [SerializeField] GameObject imagePrisma = null;
    [SerializeField] GameObject imageKubus = null;
    public TextMeshProUGUI counter;
    void Start()
    {
        int status;
        int count = 0;
        for (int i = 1; i <= 7; i++)
        {
            status = PlayerPrefs.GetInt("benda" + i, 0);
            switch (i)
            {
                case 1:
                    if (status == 1)
                    {
                        imageBola.SetActive(false);
                        bola.interactable = true;
                    }
                    else
                    {
                        bola.interactable = false;
                        imageBola.SetActive(true);
                    }
                    break;
                case 2:
                    if (status == 1)
                    {
                        imageLimas.SetActive(false);
                        limas.interactable = true;
                    }
                    else
                    {
                        imageLimas.SetActive(true);
                        limas.interactable = false;
                    }
                    break;
                case 3:
                    if (status == 1)
                    {
                        imageKerucut.SetActive(false);
                        kerucut.interactable = true;
                    }
                    else
                    {
                        imageKerucut.SetActive(true);
                        kerucut.interactable = false;
                    }
                    break;
                case 4:
                    if (status == 1)
                    {
                        imageBalok.SetActive(false);
                        balok.interactable = true;
                    }
                    else
                    {
                        imageBalok.SetActive(true);
                        balok.interactable = false;
                    }
                    break;
                case 5:
                    if (status == 1)
                    {
                        imageTabung.SetActive(false);
                        tabung.interactable = true;
                    }
                    else
                    {
                        imageTabung.SetActive(true);
                        tabung.interactable = false;
                    }
                    break;
                case 6:
                    if (status == 1)
                    {
                        imagePrisma.SetActive(false);
                        prisma.interactable = true;
                    }
                    else
                    {
                        imagePrisma.SetActive(true);
                        prisma.interactable = false;
                    }
                    break;
                case 7:
                    if (status == 1)
                    {
                        imageKubus.SetActive(false);
                        kubus.interactable = true;
                    }
                    else
                    {
                        imageKubus.SetActive(true);
                        kubus.interactable = false;
                    }
                    break;
                default:
                    break;
            }
            if (status == 1)
            {
                count++;
            }
        }
        counter.text = count + "/7";
    }

    void Update()
    {

    }
}
