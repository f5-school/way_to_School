using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DialogueTriggerCom : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S5_DialogueSystemCom>();
		system.Begin(info);
	}
}
