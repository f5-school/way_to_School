// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S8B_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S8B_DialogueSystem system;

	public Animator book,   //우아한 거짓말 버튼
					card4;  //생일 축하 카드 버튼
	
	public Animator anim_nextSpot;

	void Start() {
		var system = FindObjectOfType<S8B_DialogueSystem>();
		system.Begin(info);
	}

	void Update() {
		/*
		if (system.finishedCount == 1) {
			book.SetBool("isOpen", true);
		}

		if (system.finishedCount == 2) {
			book.SetBool("isOpen", false);
			card4.SetBool("isOpen", true);
		}

		if (system.finishedCount == 3) {
			card4.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}*/
		if (system.finishedCount == 2) {
			book.SetBool("isOpen", true);
		}

		if (system.finishedCount == 3) {
			book.SetBool("isOpen", false);
			card4.SetBool("isOpen", true);
		}

		if (system.finishedCount == 4) {
			card4.SetBool("isOpen", false);
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
