using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int moveSpeed=10;
    public int rotateSpeed=100;
    private float playerRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Input.GetAxis("Horizontal") * moveSpeed*transform.right*Time.deltaTime;
        this.transform.position += Input.GetAxis("Vertical") * moveSpeed * transform.forward * Time.deltaTime;
        //if (Input.GetMouseButton(1)) { }
        playerRotate += Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        //playerRotate %= 360;
        this.transform.rotation = Quaternion.Euler(0, playerRotate, 0);
    }
}
