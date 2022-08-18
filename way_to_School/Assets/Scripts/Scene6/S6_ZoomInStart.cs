// Scene6 - 오브젝트 Zoom-in 이후 대화창 시작에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S6_ZoomInStart : MonoBehaviour
{
	public Dialogue info;

	public S6_DialogueSystem system;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S6_DialogueSystem>();
		system.Begin(info);
	}
}
