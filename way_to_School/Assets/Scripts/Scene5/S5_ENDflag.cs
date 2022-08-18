using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class S5_ENDflag : MonoBehaviour
{
    public bool isEND = false;

    public void ClickMari()
    {
        // 마지막에 마리를 클릭할 때 이 값을 true로 바꿔서 '다음 장소로 이동' 버튼이 나올 수 있도록 설정
        isEND = true;
    }
    
}
