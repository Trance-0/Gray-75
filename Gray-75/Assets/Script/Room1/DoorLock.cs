using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public Canvas startCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void lockdoor(){
        door.GetComponent<Rigidbody>().isKinematic = true;
        door.GetComponent<AudioSource>().Play(0);
        door.transform.localEulerAngles = new Vector3(0, 0, 0);
        startCanvas.GetComponent<StartScene>().isClick = true;
    }
    public void unlockdoor() {
        door.GetComponent<AudioSource>().Play(0);
        door.GetComponent<Rigidbody>().isKinematic = false;
    }
}
