using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
