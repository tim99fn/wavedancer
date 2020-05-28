  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera: MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;
    public int space;
    public float timer;
    private float backtimer;
    public float rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ball.transform.position;   
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        

    }
     private void Update() {
       rotation=transform.rotation.x*360;
       offset=transform.position-ball.transform.position;
        if (Input.GetKey("space")){
            timer+=Time.deltaTime;
            backtimer=0;
            if (ball.transform.position.z-5>transform.position.z&&timer<1.5f){
    
       transform.position=new Vector3(-7,ball.transform.position.y+12,ball.transform.position.z-20)+new Vector3(0,0,timer*10f);
      //transform.rotation=Quaternion.Euler(50+20+offset.z,0,0);
            }  
            else if (timer>=1.5f){
              transform.position=new Vector3(-7,ball.transform.position.y+offset.y,ball.transform.position.z);  
            }
    }
      if (!(Input.GetKey("space"))){
          backtimer+=Time.deltaTime;
          timer=0;
            if (ball.transform.position.z-20<transform.position.z){
  
       transform.position= new Vector3(-7,ball.transform.position.y+12,transform.position.z);
        //transform.rotation=Quaternion.Euler(70+offset.z,0,0);
        //transform.RotateAround(ball.transform.position, new Vector3(1.0f, 0.0f, 0.0f), 50*timer);
            }
            else{
                transform.position=new Vector3(-7,ball.transform.position.y,ball.transform.position.z)+new Vector3(0,12,-20);
            }

            
    }
}
}
