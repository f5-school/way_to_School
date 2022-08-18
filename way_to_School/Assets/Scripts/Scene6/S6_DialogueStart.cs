// Scene6 - 대화창 시작 & 전체 진행에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S6_DialogueStart : MonoBehaviour
{
	public S6_DialogueSystem system;
	public Animator anim_nextSpot;

	public GameObject student1, student2, locker, desk;
	public Animator anim_mari;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S6_DialogueSystem>();
	}

	// Update is called once per frame
	void Update() {
		if (GameManager.instance.student1 && GameManager.instance.student2
			&& GameManager.instance.bullyMemo && GameManager.instance.greenNote && GameManager.instance.library_Spec && GameManager.instance.postcard3
			&& GameManager.instance.postcard2)
        {
			student1.SetActive(false);
			student2.SetActive(false);
			locker.SetActive(false);
			desk.SetActive(false);

			anim_mari.SetBool("isOpen", true);

			var flag = FindObjectOfType<S6_ENDflag>();
			if (flag.isEND)
            {
				anim_nextSpot.SetBool("isOpen", true);
			}
		}
	}
}
