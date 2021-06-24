using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceMoving : MonoBehaviour
{
    Rigidbody rigid; //선언

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>(); //초기화
        //rigid.velocity = Vector3.right; //velocity : 현재 이동속도, 벡터계열
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            rigid.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
                //Vec 방향과 크기로 힘을 줌
        }

        /*
        if(Input.GetKeyDown(KeyCode.X))
        {
            rigid.AddForce(new Vector3(1, 0, 0), ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            rigid.AddForce(new Vector3(1, 0, 0), ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            rigid.AddForce(new Vector3(-1, 0, 0), ForceMode.VelocityChange);
        }

        */

    }

    void FixedUpdate()
    {
        rigid.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")), ForceMode.Impulse);
    }
}
