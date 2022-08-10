// 수정이만 말하는 독백 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSingleStart : MonoBehaviour
{
	public SingleDialogue info;

	// Start is called before the first frame update
	void Start() {
		var system = FindObjectOfType<DialogueSingleSystem>();
		system.Begin(info);
	}
}
