using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_DialogueTrigger : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S6_DialogueSystem>();
		system.Begin(info);
	}
}
