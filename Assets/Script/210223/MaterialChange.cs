using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material black;
    public Material white;

    MeshRenderer mesh;

    bool isBlack = false;

    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isBlack == false)
        {
            mesh.material = black;
            isBlack = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            mesh.material = white;
            isBlack = false;
        }
    }

}
