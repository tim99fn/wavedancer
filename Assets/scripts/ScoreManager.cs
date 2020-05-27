using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;
    public Text HighscoreText;

    private int ScoreCounter;
    static private int HighscoreCounter;
    private int HighscoreThisGame;

    public bool alive;

    public GameObject sphere;

    public MainMenuScrpt MainMenuScrpt;


    // Start is called before the first frame update
    void Start()
    {
        HighscoreCounter = MainMenuScrpt.returnHighscore();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive){
            ScoreCounter = ((int)sphere.transform.position.z - 25)/10;
        }

        if (ScoreCounter > HighscoreThisGame){
            HighscoreThisGame = ScoreCounter;
        }
        

        if (ScoreCounter > HighscoreCounter){
            HighscoreCounter = ScoreCounter;
        }


        ScoreText.text = "Score: " + ScoreCounter;
        HighscoreText.text = "Highscore: " + HighscoreCounter;
    }

    public int returnHighscoreThisGame()
    {
        return HighscoreThisGame;
    }

    public int returnHighscore()
    {
        return HighscoreCounter;
    }
}
