using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScrpt : MonoBehaviour
{
    public string loadLevel;

    public void startGame () {

        Application.LoadLevel(loadLevel);

    }

    public void exitGame() {


        Application.Quit ();
    }
}
