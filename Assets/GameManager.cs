﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }

    public void start()
    {
        gameOverCanvas.SetActive(false);
    }
}
