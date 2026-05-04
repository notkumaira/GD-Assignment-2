using UnityEngine;
using System.Collections;
using System.Collections.Generic;   
using UnityEngine.EventSystems;

public class ItemDragging : MonoBehaviour,IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IDragHandler
{
    private RectTransform rectTrans;
    public int id;  
    public SLots currentSlot = null;
    public Canvas Canvas;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
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
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        rectTrans.anchoredPosition += eventData.delta / Canvas.scaleFactor;
    }
}
