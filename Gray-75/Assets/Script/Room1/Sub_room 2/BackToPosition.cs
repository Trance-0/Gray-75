﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y<29){
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,145,gameObject.transform.position.z);
        }
    }
}
