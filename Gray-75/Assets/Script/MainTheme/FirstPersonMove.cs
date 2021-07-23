using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMove: MonoBehaviour
{
    public GameObject playerTransform;
    public Camera cameraMain;
    public Collider groudCheck;
    public float jumpStrength = 10;
    public event System.Action Jumped;
    public int rotateSpeed = 40;
    public int moveSpeed = 10;
    private float horizontalAngle;
    private float verticalAngle;
    private bool onGround=true;
    private bool grounded;
    public GameObject waterPlane;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.GetComponent<Transform>().position.y <= waterPlane.GetComponent<Transform>().position.y)
        {
            onGround = false;
        }
        else
        {
            onGround = true;
        }
        horizontalAngle +=Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        verticalAngle +=Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
            if (verticalAngle > 80)
            {
                verticalAngle = 80;
            }
            else if (verticalAngle < -60)
            {
                verticalAngle = -60;
            }
        playerTransform.transform.position += Input.GetAxis("Horizontal") * moveSpeed * transform.right * Time.deltaTime;
        playerTransform.transform.position += Input.GetAxis("Vertical") * moveSpeed * transform.forward * Time.deltaTime;
        playerTransform.transform.rotation = Quaternion.Euler(0,horizontalAngle, 0);
       
    }
    private void LateUpdate()
    {
        cameraMain.transform.rotation = Quaternion.Euler(-verticalAngle, horizontalAngle, 0);
      
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Grounded");
        grounded = true;
        if (Input.GetKey(KeyCode.Space)&&onGround)
        {
            playerTransform.GetComponent<Rigidbody>().AddForce(Vector3.up * 100 * jumpStrength);
        }
    }
}
