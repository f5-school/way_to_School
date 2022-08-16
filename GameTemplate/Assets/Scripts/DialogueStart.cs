// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
	public Dialogue info;

	// Start is called before the first frame update
	void Start() {
		var system = FindObjectOfType<DialogueSystem>();
		system.Begin(info);
	}
}
