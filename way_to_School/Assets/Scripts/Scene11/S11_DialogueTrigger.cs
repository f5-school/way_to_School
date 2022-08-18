using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S11_DialogueTrigger : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S11_DialogueSystem>();
		system.Begin(info);
	}
}
