using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S6_LightController : MonoBehaviour
{
    public GameObject Light;
    public GameObject Postcard2;

    public Image SchoolDesk;
    public Sprite SchooolDesk_light;

    public void Start()
    {
        Postcard2.SetActive(false);
    }

    public void showCard()
    {
        SchoolDesk.sprite = SchooolDesk_light;
        Postcard2.SetActive(true);
        // 손전등 인벤토리에 넣는 코드 필요.
    }

    public void getCard()
    {
        // 카드 인벤토리에 넣는 코드 필요함.
        Postcard2.SetActive(false); // 사라지는 것 임시로 넣음
    }
}
