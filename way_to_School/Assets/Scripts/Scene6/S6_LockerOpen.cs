using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_LockerOpen : MonoBehaviour
{
    public SpriteRenderer Background_image;
    public Sprite NextBackground;

    public GameObject Postcard3;
    public GameObject BullyMemo;
    public GameObject GreenNote;

    public void Start()
    {
        Postcard3.SetActive(false);
        BullyMemo.SetActive(false);
        GreenNote.SetActive(false);
    }

    public void OpenLocker()
    {
        Background_image = FindObjectOfType<SpriteRenderer>();
        Background_image.sprite = NextBackground;

        // 카드와 초록색노트의 경우, 아직 인벤토리에 담지 않은 경우에만 나타나게 설정
        if (!GameManager.instance.postcard3)
        {
            Postcard3.SetActive(true);
        }
        if (!GameManager.instance.greenNote)
        {
            GreenNote.SetActive(true);
        }
        BullyMemo.SetActive(true);
    }
}
