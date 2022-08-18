// Scene11 - 대화창 시작 & 전체 진행에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S11_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S11_DialogueSystem system;

	public GameObject Waterspout, WoodenBox, Elec, Computer, Woonjeong;
	public Animator anim_Woonjeong;
	public Animator anim_nextSpot;

	// Start is called before the first frame update
	void Start() {
		// 처음 대화만 진행하도록 설정
		if (GameManager.instance.isFirstChat)
        {
			system = FindObjectOfType<S11_DialogueSystem>();
			system.Begin(info);
			GameManager.instance.isFirstChat = false;
		}

	}

	// Update is called once per frame
	void Update() {
		if (GameManager.instance.ElecConnect && GameManager.instance.Computer && GameManager.instance.Diagnosis &&
			GameManager.instance.HurtImage && GameManager.instance.Receipt && GameManager.instance.mp3)
        {
			Waterspout.SetActive(false);
			WoodenBox.SetActive(false);
			Elec.SetActive(false);
			Computer.SetActive(false);
			Woonjeong.SetActive(false);

			anim_Woonjeong.SetBool("isOpen", true);

			var flag = FindObjectOfType<S11_ENDflag>();
			if (flag.isEND)
			{
				anim_nextSpot.SetBool("isOpen", true);
			}
		}
	}
}
