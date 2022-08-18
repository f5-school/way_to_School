using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DialogueTrigger : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S5_DialogueSystem>();
		system.Begin(info);
	}
}
