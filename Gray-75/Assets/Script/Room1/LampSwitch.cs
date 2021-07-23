using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSwitch : MonoBehaviour
{
    public GameObject lightbulb;
    public bool lightup;
    // Start is called before the first frame update
    void Start()
    {
        lightbulb.SetActive(lightup);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void lampswitch(){
        lightup = !lightup;
        lightbulb.SetActive(lightup);
        print("FQ");
    }
}
