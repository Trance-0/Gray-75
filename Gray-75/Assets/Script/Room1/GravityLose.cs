using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityLose : MonoBehaviour
{
    public GameObject gravitylose;
    // Start is called before the first frame update
    void Start()
    {
          gravitylose.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void losegravity() {
        gravitylose.GetComponent<Rigidbody>().isKinematic = false;
        gravitylose.GetComponent<Animation>().Play();
        gravitylose.GetComponent<Rigidbody>().useGravity = false;
    }
}
