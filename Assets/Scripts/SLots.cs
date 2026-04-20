using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems; 

public class SLots : MonoBehaviour, IDropHandler
{
    public int id;
    public bool isFilled = false;          
    private GameObject currentItem = null;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            ItemDragging item = eventData.pointerDrag.GetComponent<ItemDragging>();

            if (item.id == id && !isFilled)
            {
                // Snap into place
                RectTransform itemRect = item.GetComponent<RectTransform>();
                itemRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

                // Mark slot as filled
                isFilled = true;
                currentItem = item.gameObject;

                item.currentSlot = this; // track slot in item

                // Check win condition
                GameManager.instance.CheckWin();
            }
            else
            {
                item.ResetPosition();
            }
        }
    }

}
