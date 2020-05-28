using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScrpt : MonoBehaviour
{
    private string loadLevel = "szene_game0705";

    public Text Highscore;
    public Text Score;
    public Text endscore;
    public Text HighscoreMainmenu;



    void start()
    {
         Score.enabled = false;
        endscore.enabled = false;
        Highscore.enabled = false;
        HighscoreMainmenu.enabled = true;
    }

    private void Awake()
    {
         Score.enabled = false;
        endscore.enabled = false;
        Highscore.enabled = false;
        HighscoreMainmenu.enabled = true;
    }
    
    public void startGame () 
    {
        Application.LoadLevel(loadLevel);

    }

    public void exitGame() {


        Application.Quit ();
    }

}
