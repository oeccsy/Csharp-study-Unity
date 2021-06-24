using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬과 관련된 네임스페이스

public class SceneMoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AdditiveScene2();
        }
    }

    void LoadScene2()
    {
        SceneManager.LoadScene("Scene2"); //가장 기본적인 씬 이동 방법
    }

    void AdditiveScene2()
    {
        SceneManager.LoadScene("Scene2", LoadSceneMode.Additive); //씬1이 남아있는 상태로 씬2를 불러오기
    }
}
