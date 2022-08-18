// Scene5 - 오브젝트 Zoom-in 이후 대화창 시작에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S5_ZoomInStartCom : MonoBehaviour
{
	public Dialogue info;

	public S5_DialogueSystemCom system;

	public GameObject Computer1;
	public GameObject Computer2;

	public Animator anim_nextSpot;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S5_DialogueSystemCom>();
		system.Begin(info);
	}

	void Update()
    {
		if (system.count == 1)
        {
			Computer1.SetActive(false);
        }
		if (system.count == 2)
		{
			Computer2.SetActive(false);
			anim_nextSpot.SetBool("isOpen", true);
			GameManager.instance.s5_computer = true;
		}
	}
}
