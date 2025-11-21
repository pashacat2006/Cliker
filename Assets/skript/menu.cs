using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool wh = true;
    public void OnPlay()
    {
        SceneManager.LoadScene("SampleScene");
        wh = false;
    }
    public void OnSetting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void ExtitSetting()
    {
        if (wh == false)
        {
            SceneManager.LoadScene("SampleScene");
        } else
        {
            SceneManager.LoadScene("menuMain");
        }
    }
}
