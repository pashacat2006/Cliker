using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public GameObject canvas;
    public static bool GameOver;
    public void Start()
    {
        GameOver = false;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.position = new Vector3(-0.25f, 1.6f, 0);
            canvas.SetActive(true);
            GameOver = true;
        }
    }
    public void OfGameOver()
    {
        canvas.SetActive(false);
        GameOver = false;
    }
}
