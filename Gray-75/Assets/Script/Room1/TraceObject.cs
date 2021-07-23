using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceObject : MonoBehaviour
{
    public GameObject traceObject;
    public GameObject player;
    public float moveSpeed=1f;
    private bool canmove;
    private bool movetome;
    public int a=1;
    public int speedLimit = 10;
    // Start is called before the first frame update
    void Start()
    {
        canmove = true;
        movetome = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (movetome) {
            Vector3 magic = Vector3.MoveTowards(traceObject.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            traceObject.transform.position = magic;
        }
    }
    public void traceStart() {
        if (canmove)
        {
            traceObject.GetComponent<Rigidbody>().isKinematic = false;
            traceObject.GetComponent<Rigidbody>().useGravity = false;
            print("I moved");
            canmove = false;
        }
        else {
            movetome = true;
            if (moveSpeed + a <= speedLimit)
            {
                moveSpeed += a;
            }
        }
    }
}
