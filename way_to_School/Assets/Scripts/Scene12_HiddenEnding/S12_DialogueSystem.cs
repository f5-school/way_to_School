// 수정이 포함 여러 명이 대화할 때 대화창에 대한 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class S12_DialogueSystem : MonoBehaviour {

	public Text txtSentence;

	Queue<string> sentences = new Queue<string>();

	public Animator anim_window;

	public int finishedCount = 0;

	public void Begin(Dialogue info) {
		anim_window.SetBool("isOpen", true);
		anim_window.SetBool("saidSujeong", true);

		sentences.Clear();

		foreach (var sentence in info.sentences) {
			sentences.Enqueue(sentence);
		}
		Next();
	}

	public void Next() {
		finishedCount++;

		if (sentences.Count == 0) {
			End();
			return;
		}

		txtSentence.text = string.Empty;

		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentences.Dequeue()));
	}

	IEnumerator TypeSentence(string sentence) {
		foreach (var letter in sentence) {
			txtSentence.text += letter;
			yield return new WaitForSeconds(0.0001f); // 한 글자 출력하고 0.0001초씩 대기
		}
	}

	private void End() {
		anim_window.SetBool("isOpen", false);
		txtSentence.text = string.Empty;
	}
}