using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lanemover : MonoBehaviour
{
    public float movespeed;
    private Vector3 offset;
    public int bound=15;
    protected float multiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movespeed,0,0);

    }
}
