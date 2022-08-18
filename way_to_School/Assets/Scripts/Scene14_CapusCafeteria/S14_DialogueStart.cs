// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S14_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S14_DialogueSystem system;

	public Animator TV, together;

	// Start is called before the first frame update
	void Start() {
		var system = FindObjectOfType<S14_DialogueSystem>();
		system.Begin(info);
	}

	private void Update() {
		if (system.finishedCount == 1) {
			TV.SetBool("isOpen", true);
		}
		if (system.finishedCount == 2) {
			TV.SetBool("isOpen", false);
			together.SetBool("isOpen", true);
		}
		
	}
}
