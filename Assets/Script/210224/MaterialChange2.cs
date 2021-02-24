using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange2 : MonoBehaviour
{

    MeshRenderer mesh;
    Material material;
    public Material black;
    public Material white;

    Color color;
    
    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();
        material = gameObject.GetComponent<MeshRenderer>().material; // mesh 초기화 이후 mesh.material; 와 같은 코드
        color = gameObject.GetComponent<MeshRenderer>().material.color; //material 초기화 이후 material.color; 와 같은 코드
    }

    
    void Update()
    {

        if (Input.GetKey(KeyCode.Z)) //투명도를 조절하는 코드
        {
            color.a -= 0.01f;
        }

        if(Input.GetKey(KeyCode.X))
        {
            color.a += 0.01f;
        }

        material.color = color;
        Debug.Log("color : " + color);
            
    }
}
