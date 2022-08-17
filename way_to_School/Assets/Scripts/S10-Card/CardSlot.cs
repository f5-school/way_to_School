using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlot : MonoBehaviour, IDropHandler
{
    //public int cardSpace_num = 0;

    //public void setCardSpace_num(int num)
    //{
    //    cardSpace_num = num;
    //}
    //public int getCardSpace_num()
    //{
    //    return cardSpace_num;
    //}

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
