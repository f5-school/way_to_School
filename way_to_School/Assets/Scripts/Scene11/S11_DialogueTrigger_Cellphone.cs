using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S11_DialogueTrigger_Cellphone : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S11_DialogueSystem_Cellphone>();
		system.Begin(info);
	}
}
