// Scene5 - 오브젝트 Zoom-in 이후 대화창 시작에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S5_ZoomInStart : MonoBehaviour
{
	public Dialogue info;

	public S5_DialogueSystem system;
	public Animator anim_nextSpot;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S5_DialogueSystem>();
		system.Begin(info);
		anim_nextSpot.SetBool("isOpen", true);
		GameManager.instance.calender = true;
	}
}
