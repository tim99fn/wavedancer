using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    public KeyCode increasegrav;
    public KeyCode moveLeft;
    public  KeyCode moveRight;
    public float horizVel=0;
    public int lanenum = 0;
    public bool lockcont=false;
    public float movespeed=4.0f;
    public float multiplier;
    public float downtime;
    public float yvelocity;
    public float timer;

    
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 0);
       
    this.GetComponent<Rigidbody>().AddForce(new Vector3 (0,0,movespeed),ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(moveLeft)&&lanenum==1&& lockcont==false)
        {
            horizVel = -6;
            StartCoroutine(stopSlide());
            lanenum--;
                lockcont= true;
        }
        if (Input.GetKeyDown(moveRight)&&lanenum==0&&lockcont==false)
        {
            horizVel = 6;
            StartCoroutine(stopSlide());
            lanenum++;
           lockcont= true;
        }
         

         yvelocity= GetComponent<Rigidbody>().velocity.y;

    }
    IEnumerator stopSlide()
    {
        
        yield return new WaitForSeconds(1f);
        horizVel = 0;
        lockcont = false;

    }
     private void FixedUpdate() {
      if (Input.GetKey(increasegrav)){
             if (multiplier<90){

             
             timer+=0.25f;   
             multiplier= timer*timer; 
             }    
             }
        else {
            multiplier= 0.5f;
            timer=0;;
        } 
         this.GetComponent<Rigidbody>().AddForce(Physics.gravity*this.GetComponent<Rigidbody>().mass*multiplier, ForceMode.Acceleration);
    }
   
}
