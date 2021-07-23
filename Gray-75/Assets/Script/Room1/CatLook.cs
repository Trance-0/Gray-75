using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatLook : MonoBehaviour
{
    public GameObject cat;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cat.transform.LookAt(cam.transform,Vector3.up);
    }
}
