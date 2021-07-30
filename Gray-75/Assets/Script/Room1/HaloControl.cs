using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloControl : MonoBehaviour
{
    public GameObject halo;
    public GameObject man;
    public GameObject haloLight;
    public GameObject frontDoor;
    public GameObject backDoor;
    public AudioSource BGM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {

        haloLight.GetComponent<Light>().gameObject.SetActive(false);
        halo.SetActive(false);
        BGM.Play(0);
        frontDoor.GetComponent<DoorLock>().lockdoor();
        backDoor.GetComponent<DoorLock>().lockdoor();
    }

}
