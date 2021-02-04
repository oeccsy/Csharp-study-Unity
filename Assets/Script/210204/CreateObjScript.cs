using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new GameObject(); //동적으로 빈 오브젝트 생성

        GameObject newObj = new GameObject(); //GameObject 타입의 newObject 변수를 생성
        newObj.AddComponent<DestroyObjScript> (); //newObject에 새로운 컴포넌트 부착
        newObj.name = "Add Destroy Component";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
