using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        // ���ο� �ݾ� ���� ����
        MoneyInfo info = new MoneyInfo();

        info.won = 10000;
        Debug.Log(info.cheonWon);
        Debug.Log(info.manWon);

        info.manWon = 4;
        Debug.Log(info.won);
        Debug.Log(info.cheonWon);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
