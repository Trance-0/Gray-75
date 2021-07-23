using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyRotate : MonoBehaviour
{
    public bool isClick;
    public float RotatingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        isClick=false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isClick)
        {
            gameObject.SetActive(true);
            gameObject.transform.Rotate(Vector3.up*RotatingSpeed, Space.World);
        }
    }


}
