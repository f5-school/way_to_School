using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class S5_ClickWhat : MonoBehaviour
{
    // Function to be invoked when the button is pressed
    public void ClickBtn()
    {
        string clickObject_name = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(clickObject_name);

        // 해당 클릭 요소가 무엇인지에 따라 진행도 값 설정
        // 학생들
        if (clickObject_name == "Student1")
        {
            GameManager.instance.student1 = true;
        }
        if (clickObject_name == "Student2")
        {
            GameManager.instance.student2 = true;
        }

        // Locker 요소
        if (clickObject_name == "BullyMemo")
        {
            GameManager.instance.bullyMemo = true;
        }
        if (clickObject_name == "GreenNote")
        {
            GameManager.instance.greenNote = true;
        }
        if (clickObject_name == "Library_Spec")
        {
            GameManager.instance.library_Spec = true;
        }
        if (clickObject_name == "Postcard3")
        {
            GameManager.instance.postcard3 = true;
        }

        // Desk 요소
        if (clickObject_name == "Postcard2")
        {
            GameManager.instance.postcard2 = true;
        }
    }
}
