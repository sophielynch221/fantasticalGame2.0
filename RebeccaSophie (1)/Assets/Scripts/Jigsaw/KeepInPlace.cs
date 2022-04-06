using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeepInPlace : MonoBehaviour, IDropHandler
{
    [SerializeField] private GameObject RightPiece;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Yay");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

}
