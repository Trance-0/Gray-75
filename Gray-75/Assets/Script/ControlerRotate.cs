using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerRotate : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0,speed,0));
    }
}
