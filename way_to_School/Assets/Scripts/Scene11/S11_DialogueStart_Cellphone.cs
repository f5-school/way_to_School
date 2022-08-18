// Scene11 - 대화창 시작 & 전체 진행에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S11_DialogueStart_Cellphone : MonoBehaviour
{
	public Dialogue info;

	public S11_DialogueSystem_Cellphone system;

	public Animator anim_cellphone;
	public Animator anim_postbox;

	// Start is called before the first frame update
	void Start()
	{
		system = FindObjectOfType<S11_DialogueSystem_Cellphone>();
		system.Begin(info);
	}

	// Update is called once per frame
	void Update()
	{
		if (system.count == 1)
		{
			anim_cellphone.SetBool("isOpen", true);
		}

		if (system.count == 2)
		{
			anim_cellphone.SetBool("isOpen", false);
			anim_postbox.SetBool("isOpen", true);
		}

		if (system.count == 3)
		{
			anim_postbox.SetBool("isOpen", false);
		}
	}
}
