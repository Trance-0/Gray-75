using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiater : MonoBehaviour
{
    public GameObject Obj;
    // Start is called before the first frame update
    void Start()
    {
        ObjectDisplayer.SetTextShower(Obj.GetComponent<TextShower>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
