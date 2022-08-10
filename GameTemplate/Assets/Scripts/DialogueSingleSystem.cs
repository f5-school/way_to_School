// 수정이만 말하는 독백 대화창에 대한 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSingleSystem : MonoBehaviour
{
	public Text txtName;
	public Image sujeong;
	public Text txtSentence;

	Queue<string> names = new Queue<string>();
	Queue<Sprite> sprites_sujeong = new Queue<Sprite>();
	Queue<string> sentences = new Queue<string>();

	Queue<bool> open_sujeong = new Queue<bool>();

	public Animator anim_window; 
	public Animator anim_sujeong;

	public bool isFinish = false; // 이 값은 아직 진행 중이라 미완성입니다..! 

	public void Begin(SingleDialogue info) {
		anim_window.SetBool("isOpen", true);
		
		names.Clear();
		sprites_sujeong.Clear();
		sentences.Clear();
		open_sujeong.Clear();

		foreach (var name in info.names) {
			names.Enqueue(name);
		}
		foreach (var sprite in info.sprites_sujeong) {
			sprites_sujeong.Enqueue(sprite);
		}
		foreach (var sentence in info.sentences) {
			sentences.Enqueue(sentence);
		}
		foreach (var sjOpen in info.open_sj) {
			open_sujeong.Enqueue(sjOpen);
		}

		Next();
	}

	public void Next() {
		if (sentences.Count == 0) {
			End();
			return;
		}

		txtName.text = string.Empty;
		sujeong.sprite = null;
		txtSentence.text = string.Empty;

		anim_sujeong.SetBool("isOpen", false);

		StopAllCoroutines();
		StartCoroutine(TypeSentence(names.Dequeue(), sprites_sujeong.Dequeue(), sentences.Dequeue(), open_sujeong.Dequeue()));
	}

	IEnumerator TypeSentence(string name, Sprite sj_sprite, string sentence, bool sj_open) {
		txtName.text = name;
		sujeong.sprite = sj_sprite;

		anim_sujeong.SetBool("isOpen", sj_open);

		foreach (var letter in sentence) {
			txtSentence.text += letter;
			yield return new WaitForSeconds(0.0001f); // 한 글자 출력하고 0.0001초씩 대기
		}
	}

	private void End() {
		anim_window.SetBool("isOpen", false);
		anim_sujeong.SetBool("isOpen", false);

		txtName.text = string.Empty;
		sujeong.sprite = null;
		txtSentence.text = string.Empty;

		isFinish = true; // 이 값은 아직 진행 중이라 미완성입니다..! 
	}
}
