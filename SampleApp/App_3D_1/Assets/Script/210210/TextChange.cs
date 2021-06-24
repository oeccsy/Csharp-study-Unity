using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Text txt;

    private void OnMouseUp()
    {
        txt.text = "OnMouseUp";
    }

    private void OnMouseDrag()
    {
        txt.text = "OnMouseDrag";
    }
}
