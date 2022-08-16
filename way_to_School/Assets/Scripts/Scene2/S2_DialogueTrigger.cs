using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_DialogueTrigger : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S2_DialogueSystem>();
		system.Begin(info);
	}
}
