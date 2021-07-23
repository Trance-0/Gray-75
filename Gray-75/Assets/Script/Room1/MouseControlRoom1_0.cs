using System;
using System.Collections;
using System.Collections.Generic;
using HighlightPlus;
using UnityEngine;

public class MouseControlRoom1_0 : MonoBehaviour
{
    Ray mouseRay;
    RaycastHit rayHit;
    public int distance=10000;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(mouseRay, out rayHit, distance))
            {
            //rayHit.transform.gameObject.GetComponent<HighlightEffect>().highlighted = true;
          
            if (Input.GetMouseButtonDown(0))
            {
                GameObject hit = rayHit.transform.gameObject;
                string name = hit.name;
                print(name);
             
               if (name == "deskLamp")
                {
                    hit.GetComponent<LampSwitch>().lampswitch();
                }
                else if (name == "safeCaseDoor") {
                   hit.GetComponent<SafeCaseMove>().unlock();
                   hit.GetComponent<SafeCaseMove>().openSafeCase();
                }
                else if (name=="trashcan") {
                    hit.GetComponent<TrashMove>().trashout();
                }
                else if (name=="ID card") {
                    hit.GetComponent<IDShow>().isClick = true;
                }
                
            }
        }
    }
}
