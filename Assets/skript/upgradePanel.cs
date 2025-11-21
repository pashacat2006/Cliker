using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradePanel : MonoBehaviour
{
    public GameObject panel;
    private bool activ = false;
    public void on()
    {
        if (activ == false)
        {
            panel.SetActive(true);
            activ = true;
        }
        else
        {
            panel.SetActive(false);
            activ = false;
        }
    }
    private void Start()
    {
        panel.SetActive(false);
    }
}
