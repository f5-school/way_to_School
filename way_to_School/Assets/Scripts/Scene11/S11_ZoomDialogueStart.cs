// Scene11 - 컴퓨터 씬에서 대화창 시작에 관한 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S11_ZoomDialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S11_DialogueSystem system;

	public SpriteRenderer background_image;
	public Sprite computer_on;
	public Sprite computer_off;

	// Start is called before the first frame update
	void Start() {
		if (GameManager.instance.ElecConnect)
        {
			background_image.sprite = computer_on;
			system = FindObjectOfType<S11_DialogueSystem>();
			system.Begin(info);
			GameManager.instance.Computer = true;
		} else
        {
			background_image.sprite = computer_off;
		}
	}

	// Update is called once per frame
	void Update() {
		
	}
}
