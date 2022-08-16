using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour
{
	public Text txtName;
	public Image person_image;
	public Text txtSentence;

	Queue<string> names = new Queue<string>();
	Queue<Sprite> sprites = new Queue<Sprite>();
	Queue<string> sentences = new Queue<string>();

	public Animator anim;
	public Animator anim_person;

	public void Begin(Dialogue info) {
		anim.SetBool("isOpen", true);
		anim_person.SetBool("isOpen", true);
		
		names.Clear();
		sprites.Clear();
		sentences.Clear();

		foreach (var name in info.names) {
			names.Enqueue(name);
		}
		foreach (var sprite in info.sprites) {
			sprites.Enqueue(sprite);
		}
		foreach (var sentence in info.sentences) {
			sentences.Enqueue(sentence);
		}

		Next();
	}

	public void Next() {
		if (sentences.Count == 0) {
			End();
			return;
		}

		txtName.text = string.Empty;
		person_image.sprite = null;
		txtSentence.text = string.Empty;

		StopAllCoroutines();
		StartCoroutine(TypeSentence(names.Dequeue(), sprites.Dequeue(), sentences.Dequeue()));
	}

	IEnumerator TypeSentence(string name, Sprite sprite, string sentence) {
		txtName.text = name;
		person_image.sprite = sprite;
		foreach (var letter in sentence) {
			txtSentence.text += letter;
			yield return new WaitForSeconds(0.01f); // 한 글자 출력하고 0.01초씩 대기
		}
	}

	private void End() {
		anim.SetBool("isOpen", false);
		anim_person.SetBool("isOpen", false);

		txtName.text = string.Empty;
		person_image.sprite = null;
		txtSentence.text = string.Empty;
	}
}
