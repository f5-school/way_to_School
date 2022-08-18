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
    }

    public void getCard()
    {
        Postcard2.SetActive(false);
    }
}
