using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
public class ClickAbout : MonoBehaviour
{
    public bool isClick;
    public Canvas canvas;
     public bool IsSpace;

    
    void Start ()
    {
        isClick = false;
        //获取按钮游戏对象
        GameObject btnObj = GameObject.Find ("MainMenuCanvas/About");
        //获取按钮脚本组件
        Button btn = (Button) btnObj.GetComponent<Button>();
        //添加点击侦听
        btn.onClick.AddListener (onClick);
    }

    void Update()
    {
        for (int i = 0; i < 100; i++)
        {
            if (isClick&&gameObject.transform.position.z>-703)
            {
                gameObject.transform.position -=Vector3.forward * Time.deltaTime*50;
                IsSpace = false;
            }
            else
            {
                isClick = false;
            }
        }
        if (Input.GetKeyDown (KeyCode.Q))
       {
            IsSpace = true;  
       }
       
        for (int i = 0; i < 100; i++)
        {
            if (IsSpace&&gameObject.transform.position.z<438)
            {
                gameObject.transform.position +=Vector3.forward * Time.deltaTime*50;
                isClick = false;

            }
            else
            {
                IsSpace = false;
            }
        
        }

        if ((!isClick)&&gameObject.transform.position.z>438)
        {
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
        }
    }

    void onClick ()
    {
       isClick = true;
       canvas.renderMode = RenderMode.WorldSpace;
    }
}
   

