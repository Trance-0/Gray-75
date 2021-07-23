using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class StartScene : MonoBehaviour
{
    public GameObject FirstChapter;
    private float time;
    private float a;
    private bool IsStartFadeAway;

    public bool isClick;
    
    public float ChangeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        IsStartFadeAway =false;
        isClick = false;
        a = 0f;
        FirstChapter.GetComponent<Text>().color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
       if(isClick){
           if(IsStartFadeAway)
           {
               FadeAway();
           }
           else
           {
               show();
               IsSwift();
           }
       }
    }

    void IsSwift()
    {
        if(FirstChapter.GetComponent<Text>().color.a>0.9f)
        {
            IsStartFadeAway = true;
        }

    }

    void show()
    {
        a+=Time.deltaTime*ChangeSpeed*0.1f;
        FirstChapter.GetComponent<Text>().color = Color.white;
    }

    void FadeAway()
    {
        a-=Time.deltaTime*ChangeSpeed*0.1f;
        FirstChapter.GetComponent<Text>().color = Color.white;
    }
}
