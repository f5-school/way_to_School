using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S11_Elec : MonoBehaviour
{
    public Animator anim_Wire;

    public void Connect()
    {
        anim_Wire.SetBool("Connect", true);
        GameManager.instance.ElecConnect = true;
    }
}
