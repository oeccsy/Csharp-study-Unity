using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePractice : MonoBehaviour
{
    public GameObject prefab;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load<GameObject>("Cube");
        material = Resources.Load<Material>("Black");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
