using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    private Image Background;
    public float time;
    private float a;

    public bool isClick;

    public float ChangeSpeed;
    public float BackgroundShowTime;
    public float TextShowTime;
    public float TextShowWaitTime;
    public float WaitTimeBeforeQuit;
    public Text  Text1;
    public Text  Text2;
    // Start is called before the first frame update
    void Start()
    {
        Text1.enabled = false;
        Text2.enabled =false;
        isClick = false;
        time = 0;
        a = 0f;
        Background = (Image)gameObject.GetComponent<Image>();
        Background.color = new Color(255,255,255,0);
    }

    // Update is called once per frame
    void Update()
    {
      if(isClick)
      {
          timecounter();
          if(time>=BackgroundShowTime)
          {
              show();
          }
          if(time>=TextShowTime)
          {
              Text1Show();
          }          
          if(time>=TextShowTime+TextShowWaitTime)
          {
              Text2Show();
          }
          if(time>=TextShowTime+TextShowWaitTime+WaitTimeBeforeQuit)
          {
              Back2Beginning();
          }
      }
    }

    void show()
    {
        if(Background.color.a<1f)
        {
            if(a<1f){
            a+=Time.deltaTime*ChangeSpeed*0.1f;
            Background.color = new Color(255,255,255,a);
            }
        }
    }

    void timecounter()
    {
        time += Time.deltaTime;
    }

    void Text1Show()
    {
        Text1.enabled = true;

    }
        
    void Text2Show()
    {
        Text2.enabled = true;

    }

    void Back2Beginning(){
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
        SceneManager.LoadScene("字幕+物品+FPS+BGM UI",LoadSceneMode.Additive);
    }
}
