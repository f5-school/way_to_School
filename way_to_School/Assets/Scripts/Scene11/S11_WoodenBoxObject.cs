using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S11_WoodenBoxObject : MonoBehaviour
{
    public Animator anim_Image;
    public Animator anim_Receipt;

    public void ZoomInImage()
    {
        anim_Image.SetBool("isOpen", true);
        anim_Receipt.SetBool("isOpen", true);
    }
}
