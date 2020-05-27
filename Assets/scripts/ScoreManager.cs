using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;
    public Text HighscoreText;

    private int ScoreCounter;
    private int HighscoreCounter;

    public bool alive;

    public GameObject sphere;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alive){
            ScoreCounter = ((int)sphere.transform.position.z - 25)/10;
        }
        

        if (ScoreCounter > HighscoreCounter){
            HighscoreCounter = ScoreCounter;
        }


        ScoreText.text = "Score: " + ScoreCounter;
        HighscoreText.text = "Highscore: " + HighscoreCounter;
    }

    public int returnHighscore()
    {
        return HighscoreCounter;
    }
}
