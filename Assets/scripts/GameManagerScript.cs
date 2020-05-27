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
    public string loadLevel;

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
        if (ScoreManager.returnHighscore()<50)
        {
            YourScore.text = "Congrats, you scored: " + ScoreManager.returnHighscore() + "\n" + "du Opfer";
        }
        else 
        {
            YourScore.text = " Congrats, you scored: " + ScoreManager.returnHighscore();
        }
        yield return new WaitForSeconds(5f);
        Application.LoadLevel(loadLevel);
        
    }
}
