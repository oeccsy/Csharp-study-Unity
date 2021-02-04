using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int damage = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var mon = FindObjectOfType<Monster>();
            if(Attack(mon))
            {
                Destroy(mon.gameObject);
                Debug.Log("몬스터가 죽었다!");
            }
            else
            {
                Debug.Log($"몬스터가 죽지 않았다 ! 남은 체력 :: {mon.hp}");
            }
        }
    }

    public bool Attack(Monster monster)
    {
        monster.hp -= damage;
        return monster.hp <= 0;

    }
}
