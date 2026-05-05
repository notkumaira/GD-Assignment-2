using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems; 

public class SLots : MonoBehaviour, IDropHandler
{
    public int id;
    public bool isFilled = false;          
    private GameObject currentItem = null;
    public AudioClip Thud;
    public AudioSource audioSource;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null)
        {
            ItemDragging item = eventData.pointerDrag.GetComponent<ItemDragging>();

            // CORRECT SLOT
            if (item.id == id && !isFilled)
            {
                RectTransform itemRect = item.GetComponent<RectTransform>();
                itemRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

                isFilled = true;
                Debug.Log("Correct Item Dropped!");
                audioSource.PlayOneShot(Thud);

                currentItem = item.gameObject;
                item.currentSlot = this;

                TryCheckWin();
            }
            else
            {
                // WRONG SLOT → reset
                RectTransform itemRect = item.GetComponent<RectTransform>();
                itemRect.anchoredPosition = item.GetComponent<ItemDragging>().GetOriginalPosition();

                item.currentSlot = null;
            }
        }
    }
    void TryCheckWin()
    {
        if (GameManager.instance != null)
            GameManager.instance.CheckWin();

        if (GameManager2.instance != null)
            GameManager2.instance.CheckWin();

        if (GameManager3.instance != null)
            GameManager3.instance.CheckWin();
    }

}
