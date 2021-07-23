using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BeginningText : MonoBehaviour
{
    private Text text;
    private float time;
    private float a;
    private bool IsStartFadeAway;
    public GameObject obj;

    public bool isClick;
    
    public float ChangeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        IsStartFadeAway =false;
        isClick = true;
        a = 0f;
        text = (Text)gameObject.GetComponent<Text>();
        text.color = new Color(255,255,255,0);
    }

    // Update is called once per frame
    void Update()
    {
       if(isClick){
           if(IsStartFadeAway)
           {
               FadeAway();
               if(text.color.a<0.1f)
                {
                    obj.active =true;
                }
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
        if(text.color.a>0.9f)
        {
            IsStartFadeAway = true;
        }

    }

    void show()
    {
        a+=Time.deltaTime*ChangeSpeed*0.1f;
        text.color = new Color(255,255,255,a);
    }

    void FadeAway()
    {
        a-=Time.deltaTime*ChangeSpeed*0.1f;
        text.color = new Color(255,255,255,a);
    }
    
}
