﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScrpt : MonoBehaviour
{
    private string loadLevel = "szene_game0705";
    private int HighscoreCounter;
    public ScoreManager ScoreManager;

    public void startGame () 
    {
        

        Application.LoadLevel(loadLevel);
        //HighscoreCounter = ScoreManager.returnHighscore();

    }

    public void exitGame() {


        Application.Quit ();
    }

    public int returnHighscore()
    {
        return HighscoreCounter;
    }
}
