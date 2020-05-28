using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour

{

    private lanespawner _lanespawner;
    private Vector3 platformStartpoint;

    public GameObject theSphere;
    private Vector3 SphereStartPoint;

    private string loadLevel = "Main_menu";

    public Text Endscore;
    public Text Score;
    public Text Highscore;
    public Text HighscoreMainMenu;
    public ScoreManager ScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        Endscore.enabled = false;
        Score.enabled = true;
        Highscore.enabled = true;
        HighscoreMainMenu.enabled = false;


        SphereStartPoint = theSphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {  
       
    }

    public void RestartGame()
    {
        StartCoroutine ("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        Endscore.enabled = true;
        if (ScoreManager.returnHighscoreThisGame()<50)
        {
            Endscore.text = "Congrats, you scored: " + ScoreManager.returnHighscoreThisGame() + "\n" + "du Opfer";
        }
        else 
        {
            Endscore.text = " Congrats, you scored: " + ScoreManager.returnHighscoreThisGame();
        }
        yield return new WaitForSeconds(4f);
        Application.LoadLevel(loadLevel);
        
    }
}
