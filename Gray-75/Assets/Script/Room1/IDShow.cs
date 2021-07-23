using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDShow : MonoBehaviour
{
    public GameObject camera;
    public GameObject showItem;
    public bool isClick;
    // Start is called before the first frame update
    void Start()
    {
        isClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isClick){
            show();
        }
    }

    public void show()
    {
        camera.GetComponent<ScreenBlurEffect>().isClick = true;
        showItem.GetComponent<EasyRotate>().isClick = true;
        
    }
}
