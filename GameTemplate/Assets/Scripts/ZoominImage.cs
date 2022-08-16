using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 이 스크립트는 아직 진행 중이라 미완성입니다..! 

public class ZoominImage : MonoBehaviour
{
	public Animator anim_image;
	private DialogueSystem system;

	// Start is called before the first frame update
	void Start()
    {
		system = FindObjectOfType<DialogueSystem>();
	}

    // Update is called once per frame
    void Update()
    {
		if (system.isFinish) {
			anim_image.SetBool("isOpen", true);
		}
	}
}
