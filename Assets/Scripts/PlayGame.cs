﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
