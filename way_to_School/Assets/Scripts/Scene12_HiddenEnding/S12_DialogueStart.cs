// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S12_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S12_DialogueSystem system;

	public Animator judgeSheet,		//조치결과 통보서
					anim_WJ,		//운정
					anim_nextSpot;

	void Start() {
		var system = FindObjectOfType<S12_DialogueSystem>();
		system.Begin(info);
	}
	void Update() {
		if (system.finishedCount == 2)
		{
			judgeSheet.SetBool("isOpen", true);
		}

		if (system.finishedCount == 5)
		{
			judgeSheet.SetBool("isOpen", false);
			anim_WJ.SetBool("isOpen", true);
		}

		if (system.finishedCount == 10)
		{
			anim_WJ.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
