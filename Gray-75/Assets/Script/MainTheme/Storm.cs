using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storm : MonoBehaviour
{
    public float speed;
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation += speed * Time.deltaTime;
        RenderSettings.skybox.SetFloat("_Rotation",rotation);
    }
}
