using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cam : MonoBehaviour
{
    public Camera camera1Main;
    public Camera camera2Main;
    public Sprite sprite;
    public Sprite cda;
    public GameObject coin;
    public void camOn()
    {
        camera1Main.enabled = false;
        camera2Main.enabled = true;
        coin.GetComponent<Image>().sprite = cda;
    }
    public void camOff()
    {
        camera1Main.enabled = true;
        camera2Main.enabled = false;
        coin.GetComponent<Image>().sprite = sprite;
    }
}
