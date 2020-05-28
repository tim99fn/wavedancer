using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;
    public Text HighscoreText;

    public Text HighscoreMainMenu;

    private int ScoreCounter = 0;
    static private int HighscoreCounter = 0;

    public GameObject sphere;


    // Start is called before the first frame update
    void Start()
    {
        HighscoreMainMenu.text = "Highscore: " + HighscoreCounter;
    }

    private void Awake()
    {
        //HighscoreMainMenu.text = "Current Highscore: " + HighscoreCounter;
    }
    // Update is called once per frame
    void Update()
    {
        if (ScoreCounter < ((int)sphere.transform.position.z - 25)/10)
        {
            ScoreCounter = ((int)sphere.transform.position.z - 25)/10;
        }
        

        if (ScoreCounter > HighscoreCounter)
        {
            HighscoreCounter = ScoreCounter;
        }


        ScoreText.text = "Score: " + ScoreCounter;
        HighscoreText.text = "Highscore: " + HighscoreCounter;
    }

    public int returnHighscoreThisGame()
    {
        return ScoreCounter;
    }

    public int returnHighscore()
    {
        return HighscoreCounter;
    }
}
