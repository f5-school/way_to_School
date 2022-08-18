using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class S11_ClickWhat : MonoBehaviour
{
    // Function to be invoked when the button is pressed
    public void ClickBtn()
    {
        string clickObject_name = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(clickObject_name);

        // 해당 클릭 요소가 무엇인지에 따라 진행도 값 설정
        // 컴퓨터는 컴퓨터 씬(S11_4-Computer)에서 대화창 시작 시 true로 값 변경 설정함 
        if (clickObject_name == "WJ_HurtImage_ZoomIn")
        {
            GameManager.instance.HurtImage = true;
        }
        if (clickObject_name == "Receipt_ZoomIn")
        {
            GameManager.instance.Receipt = true;
        }
        if (clickObject_name == "MP3")
        {
            GameManager.instance.mp3 = true;
        }
        if (clickObject_name == "PowerSocket")
        {
            GameManager.instance.ElecConnect = true;
        }
        if (clickObject_name == "Diagnosis_ZoomIn")
        {
            GameManager.instance.Diagnosis = true;
        }
    }
}
