﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanespawner : MonoBehaviour
{
    public GameObject [] laneprefab;
    private List <GameObject> insantiatedlanes;
   private GameObject [] instantlane;
   private Vector3 offset;
    private int random_y;
   
    // Start is called before the first frame update
    void Start()
    {
       
        for (int k=0;k<3;k++){
        for ( int i=0; i<2;i++){
        Instantiate(laneprefab[i],new Vector3(i*6,0,k*100),Quaternion.Euler(-90,90,0));
     

        }
        }
     //lanetransform=GameObject.FindGameObjectsWithTag
    }

    // Update is called once per frame
   
  
  



    
    
      public void RecyclePlatform( GameObject platform){
           offset=platform.transform.position;
platform.transform.position=offset+new Vector3(0,0,300);

platform.transform.localScale = new Vector3(platform.transform.localScale.y,Random.Range(1,30),platform.transform.localScale.z);

    }
    }
