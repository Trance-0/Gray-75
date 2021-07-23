using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TextShower : MonoBehaviour
{
    public bool isClick;
    public bool isTurned;
    public float[] time;
    public float[] TimeInterval;
    public string[] content;
    public string preText;
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
        isTurned = false;
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (isClick&&content!=null)
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
            if(counter>content.Length)
            {
                m_timer =0;
                counter = 0;
                isClick = false;
                
            }
        }
        else if (isClick&&preText!=null)
        {       
            text.text = preText;
        }
        else if(isTurned)
        {
            text.text = "";
            isTurned = !isTurned;
            isClick = !isClick;
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
    public void updateText(string[] LongText)
    {
        content = LongText;
        preText = null;
    }

    public void updateText(string text)
    {
        preText = text;
        content = null;
    }

    public void cancel()
    {
        isTurned = !isTurned;
    }

    public void onClick()
    {
        isClick=true;
    }
}

