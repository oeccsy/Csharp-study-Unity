using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 target;
    Vector3 zero = Vector3.zero;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
            transform.position = Vector3.MoveTowards(transform.position, target, 0.1f); //일반적인 이동


        if (Input.GetKey(KeyCode.R))
            transform.position = Vector3.SmoothDamp(transform.position, target, ref zero, 0.5f); //도착 직전 감속하며 이동

        if (Input.GetKey(KeyCode.T))
            transform.position = Vector3.Lerp(transform.position, target, 0.05f); //도착 직전 감속하며 이동

        if (Input.GetKey(KeyCode.Y))
            transform.position = Vector3.Slerp(transform.position, target, 0.05f); //포물선 이동

        if (Input.GetKey(KeyCode.Q))  //원위치로 이동
            transform.position = new Vector3(0, 1, 0);
    }
}
