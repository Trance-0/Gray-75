using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskList : MonoBehaviour
{
    public bool isClick;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.active =false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isClick)
        {
            gameObject.active =true;
        }

    }
}
