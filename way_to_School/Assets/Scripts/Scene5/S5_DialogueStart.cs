using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DialogueStart : MonoBehaviour
{
    public Dialogue info;
    public S5_DialogueSystem system;
    public Animator anim_nextSpot;

    public Animator anim_calender;
    public Animator anim_poster;
    public Animator anim_father;
    public Animator anim_artwork;
    public Animator anim_carpet;
    public Animator anim_drawer;


    // Start is called before the first frame update
    void Start()
    {
        system = FindObjectOfType<S3_DialogueSystem>();
        system.Begin(info);
    }

    // Update is called once per frame
    void Update()
    {
        if (system.finishedCount == 1)
        {
            anim_nextSpot.SetBool("isOpen", true);
        }
    }
}
