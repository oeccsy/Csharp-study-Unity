using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) //Is Trigger 가 체크되지 않았을때 사용
    {
        Debug.Log("충돌 시작!");
    }

    private void OnCollisionStay(Collision collision) //Is Trigger 가 체크되지 않았을때 사용
    {
        Debug.Log("충돌 중");
    }

    private void OnCollisionExit(Collision collision) //Is Trigger 가 체크되지 않았을때 사용
    {
        Debug.Log("충돌 끝");

    }


    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("트리거 시작");
    }

    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("트리거 작동중");
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("트리거 끝");
    }
}
