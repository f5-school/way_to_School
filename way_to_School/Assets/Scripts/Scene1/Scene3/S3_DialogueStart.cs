// Scene3 - 대화창 시작 & 순서에 따라 계속 진행하는 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S3_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S3_DialogueSystem system;

	public Animator anim_nextSpot;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S3_DialogueSystem>();
		system.Begin(info);
	}

	// Update is called once per frame
	void Update() {
		if (system.finishedCount == 1) {
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
