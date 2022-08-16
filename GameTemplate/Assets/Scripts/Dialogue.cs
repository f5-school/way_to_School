using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
	public List<string> names;
	public List<Sprite> sprites_sujeong;
	public List<Sprite> sprites_other;
	public List<bool> open_sj;         // 게임 창에서 수정이 인물 이미지가 나타나는지 여부
	public List<bool> open_other;      // 게임 창에서 다른 인물 이미지가 나타나는지 여부
	
	[TextArea]
	public List<string> sentences;
}
