using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
        // put this script on your camera
        // it's great for a Canvas for your UI
 
     private Camera cam;
     private float cycleSeconds = 1000f; // set to say 0.5f to test
     public GameObject sphere;

    //void start() {
    //    sphere = GetComponent<Rigidbody>();
    //}
     
     void Awake() {
         
         cam = GetComponent<Camera>();
     }
     
     void Update() {
         
         cam.backgroundColor = Color.HSVToRGB(
             Mathf.Repeat( sphere.transform.position.z / cycleSeconds, 1f),
             0.3f,     // set to a pleasing value. 0f to 1f
             0.7f      // set to a pleasing value. 0f to 1f
         );
     }
 }