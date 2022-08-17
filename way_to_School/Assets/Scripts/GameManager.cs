using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* // 싱글톤 //
     * instance라는 변수를 static으로 선언을 하여 다른 오브젝트 안의 스크립트에서도 instance를 불러올 수 있게 합니다 
     */
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null) // instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; // 내자신을 instance로 넣어줍니다.
            DontDestroyOnLoad(gameObject); // OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) // instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); // 둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
    }

    // [Scene6 진행도 체크]
    // 각 요소를 모두 진행했는지를 먼저 초기화해두고 각 요소를 진행했을 경우 true로 변경함
    // 학생1,2
    public bool student1 = false;
    public bool student2 = false;
    
    // Locker 요소
    public bool bullyMemo = false;
    public bool greenNote = false;
    public bool library_Spec = false;
    public bool postcard3 = false;

    // Desk 요소
    public bool postcard2 = false;
}