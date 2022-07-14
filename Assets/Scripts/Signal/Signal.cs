using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour
{
    // bool 타입 인자로 부딪혔을때 신호보내는 용도 
    public static bool Signal_Left ;
    public static bool Signal_Right;
    public static bool Signal_Straight;
    public static bool Signal_Uturn;

    [SerializeField] public string WhatSignal;

    void Start()
    {
        // 기본값은 false로 세팅
        Signal_Left = false;
        Signal_Right = false;
        Signal_Straight = false;
        Signal_Uturn = false;
    }

    // 부딪히면 OnTriggerEnter 발동
    private void OnTriggerEnter(Collider other)
    {
        // player 태그를 가진 오브젝트오 부딪힌다면
        if (other.gameObject.tag == "Player")
        {
            // 색깔을 빨간색으로 변경
            // (그냥 시각적 효과)
            GetComponent<MeshRenderer>().material.color = Color.red;

            // left 신호이면 Signal_Left를 true로 반환
            if (WhatSignal == "left")
            {
                Signal_Left = true;
                Debug.Log("l");
            }
            if (WhatSignal == "right")
            {
                Signal_Right = true;
                Debug.Log("r");
            }
            if (WhatSignal == "straight")
            {
                Signal_Straight = true;
                Debug.Log("s");
            }
            if (WhatSignal == "uturn")
            {
                Signal_Uturn = true;
                Debug.Log("u");
            }

        }
    }

}
