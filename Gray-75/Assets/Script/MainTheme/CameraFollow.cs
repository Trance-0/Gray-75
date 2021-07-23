using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Camera cameraFollow;
    public int rotateSpeed=50;
    public float distance=6.0f;
    public float lerpFraction=0.5f;
    private float horizontalAngle;
    private float verticalAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = playerTransform.position - playerTransform.forward * distance;
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            cameraFollow.transform.position = Vector3.Lerp(cameraFollow.transform.position, targetPosition, lerpFraction);   
        }
        else {
            horizontalAngle += Input.GetAxis("Mouse X")*rotateSpeed*Time.deltaTime;
            verticalAngle+=Input.GetAxis("Mouse Y")*rotateSpeed * Time.deltaTime;
            if (verticalAngle>80) {
                verticalAngle = 80;
            }
            else if (verticalAngle<-30)
            {
                verticalAngle = -30;
            }
            print("horisontal"+horizontalAngle+"V"+verticalAngle);
            float z = distance * Mathf.Cos(verticalAngle/180*Mathf.PI) * Mathf.Sin(horizontalAngle / 180 * Mathf.PI);
            float x = distance * Mathf.Cos(verticalAngle / 180 * Mathf.PI) * Mathf.Cos(horizontalAngle / 180 * Mathf.PI);
            float y = distance * Mathf.Sin(verticalAngle/ 180 * Mathf.PI);
            cameraFollow.transform.position = playerTransform.position + new Vector3(x, y, z);

        }
        cameraFollow.transform.LookAt(playerTransform);
    }
}
