﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    //start game button 
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //quit game button 
    public void QuitGame()
    {
        Debug.Log("This is QuitGame!");
        Application.Quit();
    }
    public void RetryGame()
    {
        Debug.Log("This is RetryGame!");
        SceneManager.LoadScene(1);
    }
}
