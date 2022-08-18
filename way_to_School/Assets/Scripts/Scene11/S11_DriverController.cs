using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S11_DriverController : MonoBehaviour
{
    public SpriteRenderer WoodenBox;
    public Sprite WoodenBox_Open;

    public GameObject HurtImageANDReceipt;

    public void Start()
    {
        HurtImageANDReceipt.SetActive(false);
    }

    public void OpenBox()
    {
        WoodenBox.sprite = WoodenBox_Open;
        HurtImageANDReceipt.SetActive(true);
    }
}
