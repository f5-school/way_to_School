// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S9_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S9_DialogueSystem system;


	public Animator anim_mari,	//마리 버튼
					card5;		//할로윈 카드 버튼
	public Animator anim_nextSpot;

	void Start() {
		var system = FindObjectOfType<S9_DialogueSystem>();
		system.Begin(info);
	}
	void Update() {
		if (system.finishedCount == 0) {
			anim_mari.SetBool("isOpen", true);
		}

		if (system.finishedCount == 1) {
			anim_mari.SetBool("isOpen", false);
			card5.SetBool("isOpen", true);       
		}
		
		if (system.finishedCount == 2) {
			card5.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
