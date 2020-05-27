using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScrpt : MonoBehaviour
{
    private string loadLevel = "szene_game0705";
    private int HighscoreCounter;
    //public ScoreManager ScoreManager;
    static int Highscore;


    private void start()
    {
        //HighscoreCounter = ScoreManager.returnHighscore();
    }
    public void startGame () 
    {
        

        Application.LoadLevel(loadLevel);

    }

    public void exitGame() {


        Application.Quit ();
    }

    public int returnHighscore()
    {
        return HighscoreCounter;
    }
}
