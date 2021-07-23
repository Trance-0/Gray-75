using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class ClickBegin : MonoBehaviour
{
    public bool isClick;
    public Canvas canvas;
    public int speed;
    public double Position;
    private ClickAbout AboutScript;
    private float m_timer;
    public int Vanishtime;
    public bool isArrive;
    public float increment_speed;
    

    
    void Start ()
    {
        isArrive = false;
        m_timer = 0;
        isClick = false;
        //获取按钮游戏对象
        GameObject btnObj = GameObject.Find ("MainMenuCanvas/Start");

        //获取按钮脚本组件
        Button btn = (Button) btnObj.GetComponent<Button>();
        AboutScript = (ClickAbout) gameObject.GetComponent<ClickAbout>();
        //添加点击侦听
        btn.onClick.AddListener (onClick);
    }

    void Update()
    {
        if (isClick)
        {       
        m_timer += Time.deltaTime;
        if (m_timer >= Vanishtime)
        {
                //canvas.enabled = false;
                if (isClick&&gameObject.transform.position.z>Position)
                {
                    gameObject.transform.position -=Vector3.forward * Time.deltaTime*speed*(increment_speed+m_timer-Vanishtime)/increment_speed;
                }
                else
                {
                    if(gameObject.transform.position.z<=Position){
                        isArrive = true;
                    }
                    isClick = false;
                }   
            } 
        }
        if (isArrive)
        {
            Arrived();
        }

    }

    void onClick ()
    {
       AboutScript.enabled = false;
       canvas.renderMode = RenderMode.WorldSpace;
       isClick = true;
       
    }

    void Arrived()
    {
        SceneManager.LoadScene("Room1");
    }
}