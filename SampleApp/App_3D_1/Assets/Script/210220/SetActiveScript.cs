using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if (obj.activeSelf == true) 
                obj.SetActive(false);
            else //오브젝트가 비활성화인경우 아래 코드 실행되지 않음.
                obj.SetActive(true);
        }
 
    }
}
