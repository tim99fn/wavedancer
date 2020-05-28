using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclegenerator : MonoBehaviour
{
    public GameObject obstacle;
    public float timer;
    public float nextspawn;
    public GameObject ball;
     private GameObject _camera;
     public float brake=10f;
     public float renew=30f;

    
    private List<GameObject> activeobstacles;
    // Start is called before the first frame update
    void Start()
    {
         _camera= GameObject.FindGameObjectWithTag("MainCamera");
    }
private void respawn_obstacle(){
    GameObject a= Instantiate(obstacle);
a.transform.position= new Vector3 (ball.transform.position.x, 60f  ,ball.transform.position.z+300f);
activeobstacles.Add(a);

}
    // Update is called once per frame
    void Update()
    {
if (timer>renew){
    brake=brake/2f;
    renew=renew*2;
}
        
        if (timer>=nextspawn){
            nextspawn+=brake;
            respawn_obstacle ();
            
        }
timer+=Time.deltaTime;
    }
    private void destroyobstacle(){
        if (activeobstacles.Count>1&& activeobstacles[0].transform.position.z<_camera.transform.position.z-20) {
            
        
            Destroy(activeobstacles[0]);
            activeobstacles.RemoveAt(0);

        }
    }    
}
