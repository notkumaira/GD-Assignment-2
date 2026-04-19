using UnityEngine;
using System.Collections;
using System.Collections.Generic;   
using UnityEngine.EventSystems;

public class ItemDragging : MonoBehaviour,IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IDragHandler
{
    private RectTransform rectTrans;
    public int id;  
    private Vector2 originalPos;
    public SLots currentSlot = null;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        originalPos = rectTrans.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click"); 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        if (currentSlot == null)
        {
            ResetPosition();
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        rectTrans.anchoredPosition += eventData.delta;
    }

    public void ResetPosition()
    {
        rectTrans.anchoredPosition = originalPos;
    }
}
