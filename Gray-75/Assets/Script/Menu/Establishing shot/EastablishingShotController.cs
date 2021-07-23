using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EastablishingShotController : MonoBehaviour
{
    public Text text;
    public Image image;
    public float timeLimit;
    private float time;
    private float a;
    private bool IsStartFadeAway;
    private float time_counter;

    public bool isClick;
    
    public float ChangeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        time_counter = 0;
        IsStartFadeAway =false;
        isClick = true;
        a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
       if(isClick){

           time_counter+=Time.deltaTime;
           if(time_counter>=timeLimit)
           {
               FadeAway();
           }
       }
    }

    void show()
    {
        a+=Time.deltaTime*ChangeSpeed*0.1f;
        text.color = new Color(255,255,255,a);
        image.color = new Color(0,0,0,a);
    }

    void FadeAway()
    {
        a-=Time.deltaTime*ChangeSpeed*0.1f;
        image.color = new Color(0,0,0,a);
        text.color = new Color(255,255,255,a);
        if(image.color.a <= 0.1f)
        {
            gameObject.active = false;
        }
    }
}
