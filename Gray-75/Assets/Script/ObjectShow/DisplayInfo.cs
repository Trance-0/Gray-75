using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayInfo : MonoBehaviour
{
    public string SinText;
    public string[] LongText; 
    public bool IsObjDisplay;
    public bool isClick;
    // Start is called before the first frame update
    void Start()
    {
        isClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetSinText()
    {
        return SinText;
    }

    public bool CheckObjDisplay()
    {
        return IsObjDisplay;
    }


    public string[] GetLongText()
    {
        return LongText;
    }

}
