using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S11_ZoomIn : MonoBehaviour
{
    public Animator anim_Wire;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.instance.ElecConnect)
        {
            anim_Wire.SetBool("Connect", true);
        }
    }
}
