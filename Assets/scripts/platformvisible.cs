using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformvisible : MonoBehaviour

{
    public bool visible=false;
private lanespawner _lanespawner;
private GameObject _camera;
    // Start is called before the first frame update   private lanespawner _lanespawner; 
     private void Start(){
         _lanespawner=GameObject.FindObjectOfType<lanespawner>();
        _camera= GameObject.FindGameObjectWithTag("MainCamera");
    }
      void Update() {
       
    
        if(_camera.transform.position.z>(this.transform.position.z+100)){
           _lanespawner.RecyclePlatform(this.gameObject);

        }
      }
}