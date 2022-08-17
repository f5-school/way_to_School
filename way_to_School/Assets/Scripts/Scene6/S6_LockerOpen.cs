using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_LockerOpen : MonoBehaviour
{
    public SpriteRenderer Background_image;
    public Sprite NextBackground;

    public GameObject Postcard3;
    public GameObject CrumpledPaper;
    public GameObject GreenNote;

    public void Start()
    {
        Postcard3.SetActive(false);
        CrumpledPaper.SetActive(false);
        GreenNote.SetActive(false);
    }

    public void OpenLocker()
    {
        Background_image = FindObjectOfType<SpriteRenderer>();
        Background_image.sprite = NextBackground;

        Postcard3.SetActive(true);
        CrumpledPaper.SetActive(true);
        GreenNote.SetActive(true);
    }
}
