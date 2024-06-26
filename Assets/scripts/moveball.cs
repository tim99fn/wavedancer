﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    public KeyCode increasegrav;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float horizVel=0;
    public int lanenum = 0;
    public bool lockcont=false;
    public float movespeed=10.0f;
    public float multiplier;
    public float downtime;
    public float yvelocity;
    public float timer;

    public GameManagerScript theGameManager;
    private lanespawner _lanespawner;
    private GameObject obstacle;

    
    // Start is called before the first frame update
    void Start()
    {
        
       GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 0);

       _lanespawner=GameObject.FindObjectOfType<lanespawner>();
       
    this.GetComponent<Rigidbody>().AddForce(new Vector3 (0,0,movespeed),ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(moveLeft)&&lanenum==1)
        {GetComponent<Rigidbody>().transform.position=new Vector3 (0,GetComponent<Rigidbody>().transform.position.y,GetComponent<Rigidbody>().transform.position.z);
        lanenum=0;
        }
        if (Input.GetKeyDown(moveRight)&&lanenum==0)
        {
            GetComponent<Rigidbody>().transform.position= new Vector3 (6,GetComponent<Rigidbody>().transform.position.y,GetComponent<Rigidbody>().transform.position.z);
            lanenum=1;
        }
         


         yvelocity= GetComponent<Rigidbody>().velocity.y;

        if (GetComponent<Rigidbody>().velocity.z < 0 || GetComponent<Rigidbody>().position.y < -32)
        {
            theGameManager.RestartGame();
        }
      
    }

     private void FixedUpdate() {
      if (Input.GetKey(increasegrav)){
             if (multiplier<90){

             
             timer+=0.25f;   
             multiplier= timer*5; 
             }    
             }
        else {
            multiplier= 0.7f;
            timer=0;
        } 

         this.GetComponent<Rigidbody>().AddForce(Physics.gravity*this.GetComponent<Rigidbody>().mass*multiplier, ForceMode.Acceleration);
    }
    private void OnTriggerEnter(Collider other) {
         theGameManager.RestartGame();
    }
}