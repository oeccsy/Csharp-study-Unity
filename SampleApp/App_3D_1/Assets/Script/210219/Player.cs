using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    float hAxis;
    float vAxis;
    bool wDown;
    bool jDown;
    bool isJump;

    Vector3 moveVec;

    Rigidbody rigid; // 여기있는 변수들은 Awake에서 초기화시켜준다!
    Animator anim;
    public AudioSource jumpSound;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>(); //자식 오브젝트에 있는 컴포넌트를 가지고온다.
    }

    // Update is called once per frame
    void Update()
    {
        GetInput(); //입력을 받는다.
        Move(); //입력받은 값에 따라 움직인다.
        Turn(); //움직이는 방향을 바라보도록 한다.
        Jump();

    }

    
    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Shift");
        jDown = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        if (wDown == false)
        {
            transform.position += moveVec * speed * Time.deltaTime;
        }
        else
        {
            transform.position += moveVec * speed * 0.3f * Time.deltaTime;
        }

        anim.SetBool("isWalk", moveVec != Vector3.zero); //SetBool() 은 파라메터 값을 설정할 수 있다.
        anim.SetBool("isOpen", wDown);
    }

    void Turn()
    {
        transform.LookAt(transform.position + moveVec); //본인이 향하고 있는 위치를 바라보게 만드는 코드
    }

    void Jump()
    {
        if (jDown && !isJump)
        {
            rigid.AddForce(Vector3.up * 7, ForceMode.Impulse); //즉발적인 힘을 가하는 경우 Impulse를 사용한다.
            anim.SetBool("isJump", true);
            anim.SetTrigger("doJump");
            isJump = true;

            jumpSound.Play();
        }   
    }

    void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            anim.SetBool("isJump", false);
            isJump = false;
        }
    }
}
