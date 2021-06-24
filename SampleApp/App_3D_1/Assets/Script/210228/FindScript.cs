using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Material black;
    Material mat;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Box");
            //태그로 장면의 모든 오브젝트 추출

            for (int i = 0; i < objs.Length; i++)
            {
                Destroy(objs[i]);
            }
        }
        GameObject obj = GameObject.FindGameObjectWithTag("Box");
        //태그로 장면의 오브젝트 하나 추출
    }
}
