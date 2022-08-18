// Scene5 - 대화창 시작 & 전체 진행에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S5_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S5_DialogueSystem system;
	public Animator anim_nextSpot;

	public GameObject Drawer, Computer, Calender;

	// Start is called before the first frame update
	void Start() {
		if (!GameManager.instance.passFirst)
        {
			system = FindObjectOfType<S5_DialogueSystem>();
			system.Begin(info);
			GameManager.instance.passFirst = true;
		}
	}

	// Update is called once per frame
	void Update() {
		if (GameManager.instance.drawer && GameManager.instance.s5_computer && GameManager.instance.calender)
        {
			Drawer.SetActive(false);
			Computer.SetActive(false);
			Calender.SetActive(false);

			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
