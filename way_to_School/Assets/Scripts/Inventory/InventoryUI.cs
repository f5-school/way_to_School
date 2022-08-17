using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

	public GameObject inventoryPanel;
	public Animator anim_inventory;
	public GameObject inventoryCloseBtn;
	public bool activeCloseBtn = false;		//인벤토리 close 버튼 활성화 관련

	public Slot[] slots;
	public Transform slotHolder;

    void Start()
    {
		inventoryCloseBtn.SetActive(activeCloseBtn);
		slots = slotHolder.GetComponentsInChildren<Slot>();
	}

	public void InventoryOpen()     // 인벤 버튼 클릭 시 인벤토리 열림
	{
		anim_inventory.SetBool("InvenBtn", true);
		activeCloseBtn = !activeCloseBtn;
		inventoryCloseBtn.SetActive(activeCloseBtn);		//인벤토리 닫힘버튼(여백) 활성화
	}

	public void InventroyClose() {
		anim_inventory.SetBool("InvenBtn", false);
		activeCloseBtn = !activeCloseBtn;
		inventoryCloseBtn.SetActive(activeCloseBtn);		//인벤토리 닫힘버튼(여백) 비활성화
	}
}
