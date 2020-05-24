using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    //public lanespawner platformGenerator;
    //private Vector3 platformStartpoint;

    public GameObject theSphere;
    private Vector3 SphereStartPoint;
    // Start is called before the first frame update
    void Start()
    {
        //platformStartpoint = platformGenerator.position;
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
        yield return new WaitForSeconds(2f);
        theSphere.transform.position = SphereStartPoint;
        //platformGenerator.position = platformStartpoint;
    }
}
