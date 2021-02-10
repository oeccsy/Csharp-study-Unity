using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public Text txt;
    public Text txt2;

    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            txt.text = "x: " + touch.position.x + ", y: " + touch.position.y;
            Touch touch2 = Input.GetTouch(1);
            txt2.text = "x: " + touch2.position.x + ", y: " + touch2.position.y;
            
              
        }
        
    }
}
