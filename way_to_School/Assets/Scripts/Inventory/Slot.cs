using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour {
	public Item item; // 획득한 아이템
	public Image itemImage;  // 아이템의 이미지


	// 인벤토리에 새로운 아이템 슬롯 추가
	public void AddItem(Item _item) {
		item = _item;
		itemImage.sprite = item.itemImage;
	}

	// 슬롯의 아이템 제거
	private void ClearSlot() {
		item = null;
		itemImage.sprite = null;
	}
}
