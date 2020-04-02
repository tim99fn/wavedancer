﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera: MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ball.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
    }
}
