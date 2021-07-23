using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithUI : MonoBehaviour
{
    public GameObject objectWithUI;
    public Canvas UIofObject;
    // Start is called before the first frame update
    void Start()
    {
        UIofObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            UIofObject.gameObject.SetActive(false);
        }
    }
    public void openUI() {
        print("set UI bookOnDesk active, press E to deactive UI.");
        UIofObject.gameObject.SetActive(true);
    }
}
