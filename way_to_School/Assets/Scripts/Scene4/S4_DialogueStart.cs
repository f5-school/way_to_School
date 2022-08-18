// Scene4 - 대화창 시작 & 순서에 따라 계속 진행하는 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S4_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S4_DialogueSystem system;

	public Animator anim_nextSpot;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S4_DialogueSystem>();
		system.Begin(info);
	}

	// Update is called once per frame
	void Update() {
		if (system.finishedCount == 1) {
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
