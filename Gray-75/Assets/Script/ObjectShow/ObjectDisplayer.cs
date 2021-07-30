using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectDisplayer
{
    public static Camera cam;
    public static Camera mainCam;
    public static GameObject obj;
    public static TextShower textSh;
    public static AudioSource AS;
    public static string[] LongText;
    public static int distance = 2;
    public static int RotatingSpeed = 1;

    public static void SetCamera(Camera camera)
    {
        cam = camera;
        cam.clearFlags = CameraClearFlags.Depth;
        cam.cullingMask = 1<<5;
        cam.orthographic = false;
        cam.fieldOfView = 60;
        cam.depth = -1;
        cam.transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
        Debug.Log("Camera Set");
    }

    public static void SetMainCamera(Camera camera)
    {
        mainCam = camera;
        Debug.Log("Main Camera Set");
    }

    public static void SetObject(GameObject oobject)
    {
        if(obj!= null)
        {
            GameObject.Destroy(obj,0.0f);
        }
        obj = GameObject.Instantiate(oobject);
        obj.layer = LayerMask.NameToLayer("UI");
        Debug.Log("Obj initiated");
        obj.transform.position = new Vector3(cam.transform.position.x,cam.transform.position.y,cam.transform.position.z+distance);
        if(oobject.GetComponent<DisplayInfo>().GetSinText()!= null)
        {
            textSh.updateText(oobject.GetComponent<DisplayInfo>().GetSinText());
            Debug.Log("Sintext");

        }
        else if(oobject.GetComponent<DisplayInfo>().GetLongText()!= null)
        {

            textSh.updateText(oobject.GetComponent<DisplayInfo>().GetLongText());
            Debug.Log("LongText");
        }
        

    }

    public static void Display()
    {
        if(!GetDisplayStatus()&&obj.GetComponent<DisplayInfo>().CheckObjDisplay())
        {
            cam.depth = 100;
            //mainCam.GetComponent<BlurOptimized>().enabled = true;
            AS.Play();
            Debug.Log("Displayed");
        }
        textSh.onClick();

    }


    public static void CancelDisplay()
    {
            cam.depth = -1;
            //mainCam.GetComponent<BlurOptimized>().enabled = false;
            textSh.cancel();

    }

    public static void ObjRotate()
    {
        if(GetDisplayStatus())
        {
            obj.transform.Rotate(Vector3.up*RotatingSpeed, Space.World);            
        }
    }

    public static bool GetDisplayStatus()
    {
        if(cam.depth ==100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void SetTextShower(TextShower ts)
    {
        textSh = ts;
    }

    public static void SetAS(AudioSource As)
    {
        AS = As;
    }
}
