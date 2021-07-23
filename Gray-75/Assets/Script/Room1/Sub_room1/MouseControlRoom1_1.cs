using System;
using HighlightPlus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MouseControlRoom1_1: MonoBehaviour
{
    Ray mouseRay;
    RaycastHit rayHit;
    public int distance=10000;
    public float generateDis = 0.5f;
    private List<GameObject> FloatingObject;
// Start is called before the first frame update
void Start()
    {
        FloatingObject = new List<GameObject>();
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
                if (FloatingObject.Contains(hit))
                {
                    Vector3 temp= new Vector3(Random.Range(-generateDis,generateDis), Random.Range(-generateDis, generateDis), Random.Range(-generateDis, generateDis));
                    GameObject tempObject=Instantiate(hit, hit.transform.position+temp, hit.transform.rotation);
                    tempObject.GetComponent<HighlightEffect>().SetHighlighted(false);
                }
                else if (hit.tag=="GravityLoss")
                {
                    hit.GetComponent<GravityLose>().losegravity();
                    FloatingObject.Add(hit);
                    print(FloatingObject.Count);
                }
                else if (hit.tag == "TraceObject")
                {
                    hit.GetComponent<TraceObject>().traceStart();
                }
            }
        }
    }
}
