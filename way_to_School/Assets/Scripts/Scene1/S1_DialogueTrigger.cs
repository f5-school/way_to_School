using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1_DialogueTrigger : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S1_DialogueSystem>();
		system.Begin(info);
	}
}
