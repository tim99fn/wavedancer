using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    public KeyCode moveLeft;
    public  KeyCode moveRight;
    public float horizVel=0;
    public int lanenum = 0;
    public bool lockcont=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 0);
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

    }
    IEnumerator stopSlide()
    {
        
        yield return new WaitForSeconds(1f);
        horizVel = 0;
        lockcont = false;
    }
}
