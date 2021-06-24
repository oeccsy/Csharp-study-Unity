using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
            Debug.Log("GetKeyDown U");

        if (Input.GetKeyUp(KeyCode.I))
            Debug.Log("GetKeyUp I");

        if (Input.GetKey(KeyCode.O))
            Debug.Log("GetKey O");

        /*

        if (Input.GetButtonDown("Shift"))
            Debug.Log(Input.GetButtonDown("Shift"));

        if (Input.GetButtonUp("Shift"))
            Debug.Log(Input.GetButtonUp("Shift"));

        */

        if (Input.GetButton("Shift"))
            Debug.Log(Input.GetButton("Shift"));




        //Debug.Log("GetAxisRaw : " + Input.GetAxisRaw("Horizontal") + "호라이즌탈 로");

        //Debug.Log("GetAxis : " + Input.GetAxis("Vertical"));

        //Debug.Log("점프 : " + Input.GetAxis("Jump"));


    }
}
