using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScrpt : MonoBehaviour
{
    
    public void startGame (string scene) {

        SceneManager.LoadScene(scene);

    }

    public void exitGame() {


        Application.Quit ();
    }
}
