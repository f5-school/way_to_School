using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S11_Waterspout : MonoBehaviour
{
    public SpriteRenderer Background_image;
    public Sprite NextBackground;

    public Animator anim_diagnosis;

    public void Start()
    {
        
    }

    public void GetDiagnosis()
    {
        Background_image = FindObjectOfType<SpriteRenderer>();
        Background_image.sprite = NextBackground;

        anim_diagnosis.SetBool("isOpen", true);
    }
}
