using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveLeft()
    {
        transform.Translate(new Vector3(-0.5f, 0f, 0f));
    }

    public void MoveRight()
    {
        transform.Translate(new Vector3(0.5f, 0f, 0f));
    }
}
