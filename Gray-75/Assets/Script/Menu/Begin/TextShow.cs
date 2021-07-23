using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TextShow : MonoBehaviour
{

    
    public bool isClick;
    public float[] time;
    public float[] TimeInterval;
    public string[] content;
    public int counter;
    public float m_timer;
    private Button btn;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        m_timer =0;
        isClick = false;
        counter = 0;
        GameObject btnObj = GameObject.Find ("MainMenuCanvas/Start");
        //获取按钮脚本组件
        btn = (Button) btnObj.GetComponent<Button>();
        //添加点击侦听
        btn.onClick.AddListener (onClick);

    }

    // Update is called once per frame
    void Update()
    {
        if (isClick)
        {       
             m_timer += Time.deltaTime;
            if(TimeInterval[counter]!=0)  
            {      
                if (m_timer >= time[counter]&&m_timer <= time[counter]+TimeInterval[counter])
                {
                    text.text = content[counter];
                }
                else if(m_timer >= time[counter]+TimeInterval[counter])
                {
                    text.text = "";
                    counter++;
                } 
            }
            else
            {
                if (m_timer >= time[counter])
                {
                    text.text = content[counter];
                    counter++;
                }
            }
        }

//            if(TimeInterval[counter]!=0)
//            {
//                if(m_timer >= time[counter]+TimeInterval[counter])
//                {
//                text.text = "";
//                }
//            }
//            if(m_timer >= time[counter]+TimeInterval[counter])
//            {
//            text.text = "";
//            }
//        }
    }

    void onClick()
    {
        isClick=true;
    }
}
