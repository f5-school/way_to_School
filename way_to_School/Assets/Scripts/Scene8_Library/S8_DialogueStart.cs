// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S8_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S8_DialogueSystem system;

	public Animator anim_nextSpot;
	public Animator anim_card4;
	public GameObject LibTeacher, CleanStu, BookShelf;		//단서를 모두 확인했는지 검사하기 위해 받음

	// Start is called before the first frame update
	void Start() {
		var system = FindObjectOfType<S8_DialogueSystem>();
		system.Begin(info);
	}
	void Update()
	{
		if ((BookShelf.activeSelf == false))
        {
			anim_card4.SetBool("isOpen", true);
        }
		if ((LibTeacher.activeSelf == false) && (CleanStu.activeSelf == false) && (BookShelf.activeSelf == false))
		{
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
