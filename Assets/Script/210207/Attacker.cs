using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public bool isDelay;
    public float delayTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //딜레이상태가 아니면 공격하는 기능
        {
            if(!isDelay)
            {
                isDelay = true;
                Debug.Log("공격!");
                StartCoroutine(CountAttackDelay());
            }
            else
            {
                Debug.Log("딜레이중 . . ");
            }
        }

        /*
        if(isDelay) //2초마다 딜레이상태를 풀어주는 기능
        {
            timer += Time.deltaTime;
            if(timer>=delayTime)
            {
                timer = 0f;
                isDelay = false;
            }
        }
        */
    }

    IEnumerator CountAttackDelay()
    {
        yield return new WaitForSeconds(delayTime);
        isDelay = false;
    }
}
