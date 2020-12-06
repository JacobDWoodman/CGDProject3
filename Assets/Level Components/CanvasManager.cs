﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject winElements;
    [SerializeField] private GameObject loseElements;
    
    private static CanvasManager instance;

    void Awake()
    {
        instance = this;
    }

    public static void ShowWin()
    {
        instance.winElements.SetActive(true);
    }
    
    public static void ShowLose()
    {
        instance.loseElements.SetActive(true);
    }

    public static void loadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public static void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}