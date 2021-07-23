using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCaseMove : MonoBehaviour
{
    public GameObject safeCaseDoor;
    private bool locked;
    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        safeCaseDoor.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openSafeCase() {
        if (!locked) {
            safeCaseDoor.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    public void unlock() {
        locked = false;
    }
}
