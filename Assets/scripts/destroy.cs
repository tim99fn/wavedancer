using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class destroy : MonoBehaviour
{
    private GameObject _camera;

    // Start is called before the first frame update
    void Start()
    {
         _camera= GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z<_camera.transform.position.z-20){
            Destroy(this.gameObject);
        }
    }
}
