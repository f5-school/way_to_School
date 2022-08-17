// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S8BS_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S8BS_DialogueSystem system;

	void Start() {
		var system = FindObjectOfType<S8BS_DialogueSystem>();
		system.Begin(info);
	}
}
