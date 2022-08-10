using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

	public GameObject inventoryPanel;
	bool activeInventory = false;	// 인벤토리 활성화 관련

	public Slot[] slots;
	public Transform slotHolder;

    void Start()
    {
		inventoryPanel.SetActive(activeInventory);
		slots = slotHolder.GetComponentsInChildren<Slot>();
	}

	public void InventoryOpen()     // 인벤 버튼 클릭 시 인벤토리 열림
	{
		activeInventory = !activeInventory;
		inventoryPanel.SetActive(activeInventory);
	}
}
