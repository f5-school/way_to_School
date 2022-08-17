// Scene6 - 책상서랍 속 카드를 인벤토리에 담은 후 보이지 않게 설정하는 코드

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_ShowObject : MonoBehaviour
{
    public GameObject Object;

    // Start is called before the first frame update
    void Start()
    {
        // 아직 인벤토리에 담지 않은 경우에만 나타나게 설정
        if (Object.name == "Postcard2" && !GameManager.instance.postcard2)
        {
            Object.SetActive(true);
        }
    }
}
