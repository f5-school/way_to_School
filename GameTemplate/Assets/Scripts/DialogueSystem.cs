// ������ ���� ���� ���� ��ȭ�� �� ��ȭâ�� ���� �ڵ�
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour
{
	public Text txtName;
	public Image sujeong;
	public Image other_person;
	public Text txtSentence;

	Queue<string> names = new Queue<string>();
	Queue<Sprite> sprites_sujeong = new Queue<Sprite>();
	Queue<Sprite> sprites_other = new Queue<Sprite>();
	Queue<string> sentences = new Queue<string>();

	Queue<bool> open_sujeong = new Queue<bool>();
	Queue<bool> open_other = new Queue<bool>();

	public Animator anim_window; 
	public Animator anim_sujeong;
	public Animator anim_other;

	public bool isFinish = false; // �� ���� ���� ���� ���̶� �̿ϼ��Դϴ�..! 

	public void Begin(Dialogue info) {
		anim_window.SetBool("isOpen", true);
		
		names.Clear();
		sprites_sujeong.Clear();
		sprites_other.Clear();
		sentences.Clear();
		open_sujeong.Clear();
		open_other.Clear();

		foreach (var name in info.names) {
			names.Enqueue(name);
		}
		foreach (var sprite in info.sprites_sujeong) {
			sprites_sujeong.Enqueue(sprite);
		}
		foreach (var sprite in info.sprites_other) {
			sprites_other.Enqueue(sprite);
		}
		foreach (var sentence in info.sentences) {
			sentences.Enqueue(sentence);
		}
		foreach (var sjOpen in info.open_sj) {
			open_sujeong.Enqueue(sjOpen);
		}
		foreach (var otherOpen in info.open_other) {
			open_other.Enqueue(otherOpen);
		}

		Next();
	}

	public void Next() {
		if (sentences.Count == 0) {
			End();
			return;
		}

		txtName.text = string.Empty;
		other_person.sprite = null;
		sujeong.sprite = null;
		txtSentence.text = string.Empty;

		anim_sujeong.SetBool("isOpen", false);
		anim_other.SetBool("isOpen", false);

		StopAllCoroutines();
		StartCoroutine(TypeSentence(names.Dequeue(), sprites_sujeong.Dequeue(), sprites_other.Dequeue(), sentences.Dequeue(), open_sujeong.Dequeue(), open_other.Dequeue()));
	}

	IEnumerator TypeSentence(string name, Sprite sj_sprite, Sprite other_sprite, string sentence, bool sj_open, bool other_open) {
		txtName.text = name;
		sujeong.sprite = sj_sprite;
		other_person.sprite = other_sprite;

		anim_sujeong.SetBool("isOpen", sj_open);
		anim_other.SetBool("isOpen", other_open);

		foreach (var letter in sentence) {
			txtSentence.text += letter;
			yield return new WaitForSeconds(0.0001f); // �� ���� ����ϰ� 0.0001�ʾ� ���
		}
	}

	private void End() {
		anim_window.SetBool("isOpen", false);
		anim_sujeong.SetBool("isOpen", false);
		anim_other.SetBool("isOpen", false);

		txtName.text = string.Empty;
		other_person.sprite = null;
		sujeong.sprite = null;
		txtSentence.text = string.Empty;

		isFinish = true; // �� ���� ���� ���� ���̶� �̿ϼ��Դϴ�..! 
	}
}