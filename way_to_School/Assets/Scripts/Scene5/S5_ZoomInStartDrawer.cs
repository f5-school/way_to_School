// Scene5 - 오브젝트 Zoom-in 이후 대화창 시작에 관련된 코드
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class S5_ZoomInStartDrawer : MonoBehaviour
{
	public Dialogue info;

	public S5_DialogueSystemDrawer system;

	public GameObject Drawer1;
	public GameObject Drawer2;
	public GameObject Drawer3;
	public GameObject Drawer4;

	public Animator anim_nextSpot;

	// Start is called before the first frame update
	void Start() {
		system = FindObjectOfType<S5_DialogueSystemDrawer>();
		system.Begin(info);
	}

	void Update()
    {
		if (system.count == 1)
        {
			Drawer1.SetActive(false);
        }
		if (system.count == 2)
		{
			Drawer2.SetActive(false);
		}
		if (system.count == 3)
		{
			Drawer3.SetActive(false);
		}
		if (system.count == 4)
		{
			Drawer4.SetActive(false);
			anim_nextSpot.SetBool("isOpen", true);
			GameManager.instance.drawer = true;
		}
	}
}
