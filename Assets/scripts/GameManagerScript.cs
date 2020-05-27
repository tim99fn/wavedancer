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

    public GameObject[] wavelist;
    private string loadLevel = "Main_menu";

    public Text YourScore;
    public ScoreManager ScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        YourScore.enabled = false;
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
        YourScore.enabled = true;
        if (ScoreManager.returnHighscoreThisGame()<50)
        {
            YourScore.text = "Congrats, you scored: " + ScoreManager.returnHighscoreThisGame() + "\n" + "du Opfer";
        }
        else 
        {
            YourScore.text = " Congrats, you scored: " + ScoreManager.returnHighscoreThisGame();
        }
        yield return new WaitForSeconds(5f);
        Application.LoadLevel(loadLevel);
        
    }
}
