using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{

    void Start()
    {
        
    }

    float timer = 0f;
    
    [SerializeField]
    private Transform lookingObject;

    void Update()
    {
        timer += Time.deltaTime;
        LookObject(lookingObject);
        Scaling(new Vector3(Mathf.Cos(timer)+2f, 2f, 2f));
    }


    //크기 조절

    public void Scaling(Vector3 newScale)
    {
        transform.localScale = newScale;
    }


    //Forward, LookPosition

    public void RotateControlForward(Vector3 dir)
    {
        transform.forward = dir; //바라보는 방향을 정하는 방법
    }

    public void LookPosition(Vector3 pos)
    {
        transform.LookAt(pos); //바라보는 위치를 정하는 방법
    }

    public void LookObject(Transform lookObj)
    {
        transform.LookAt(lookObj); //게임 오브젝트를 바라보게 만들 수 도 있음
    }



    //각 조절
    public void RotateGameObject(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation); //Quaternion 대신 Euler 체계를 사용
                                                        //해당 각도상태로 고정

    }

    public void Rotatef(Vector3 rotation)
    {
        transform.Rotate(rotation); //매 프레임마다 해당 방향으로 회전한다.
    }



    //위치 조절

    private void MovePosition(Vector3 newPos)
    {
        transform.position = newPos; //transform.position 은 MonoBehaviour 로부터 상속받은 프로퍼티
                                    //위치를 매개변수로 받는다. 해당 위치에 고정된다.
    }


    private void MoveTranslate(Vector3 moveVector)
    {
        transform.Translate(moveVector); //Translate 는 프레임마다 원래 위치에서 vector만큼 움직인다.
                                        //이동할 방향과 속력을 매개변수로 받는것과 같다.
    }
}
