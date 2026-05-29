using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragging : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public int id;
    public SLots currentSlot;

    private RectTransform rectTransform;
    private Vector2 originalPosition;
    public Canvas Canvas;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = rectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / Canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // If not placed in a valid slot ? reset position
        if (currentSlot == null)
        {
            rectTransform.anchoredPosition = originalPosition;
        }
    }
    public Vector2 GetOriginalPosition()
    {
        return originalPosition;
    }
}