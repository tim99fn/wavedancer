using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        YourScore.text = " Congrats, you scored: " + ScoreManager.returnHighscore();
        yield return new WaitForSeconds(2f);
        Application.LoadLevel(loadLevel);
        
    }
}
