using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisplayerController : MonoBehaviour
{   
    public GameObject[] ObjList;
    public Camera mainCam;
    public Camera Cam;
    public AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {
        SetCamera(Cam,mainCam);
        SetAS(AS);
      //  coun = new TimeCounter();
    }

    // Update is called once per frame
    void Update()
    {

        CheckObject();
        AlwaysDo();

    }

    public void CheckObject()
    {
        foreach (GameObject obj in ObjList)
        {
            if(obj.GetComponent<DisplayInfo>().isClick)
            {
                SetObject(obj);
                Display();
                obj.GetComponent<DisplayInfo>().isClick = false;
            }
        }
        if(GetDisplayStatus()&&Input.GetKeyDown(KeyCode.Q))
        {
            CancelDisplay();
        }
    }

    public void AlwaysDo()
    {
        Rotate();
    }

   // public void TimedOrder(float time)
    //{
    //    if(ObjectDisplayer.GetDisplayStatus())
    //    {
      //      coun.Start();
        //}
        //else
        //{
         //   coun.End();
        //}
        //coun.Add(time);
    //}
    
    public void CancelDisplay()
    {
        ObjectDisplayer.CancelDisplay();
    }

    public void SetCamera(Camera cam,Camera mainCam)
    {
        ObjectDisplayer.SetCamera(cam);
        ObjectDisplayer.SetMainCamera(mainCam);
    }

    private void Rotate()
    {
        ObjectDisplayer.ObjRotate();
    }

    public void SetObject(GameObject obj)
    {
        ObjectDisplayer.SetObject(obj);
    }

    public void Display()
    {
        ObjectDisplayer.Display();
    }

    public bool GetDisplayStatus()
    {
        return ObjectDisplayer.GetDisplayStatus();
    }

    public void SetAS(AudioSource As)
    {
        ObjectDisplayer.SetAS(As);
    }

}
