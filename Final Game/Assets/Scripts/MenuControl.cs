﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("scene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
