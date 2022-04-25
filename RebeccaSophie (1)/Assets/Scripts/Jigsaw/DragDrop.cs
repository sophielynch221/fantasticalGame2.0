using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasgroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begindragging");
        canvasgroup.blocksRaycasts = false;
        canvasgroup.alpha = .75f;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Enddragging");
        canvasgroup.blocksRaycasts = true;
        canvasgroup.alpha = 1f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
        rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }

}

