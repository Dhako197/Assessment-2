using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler,  IDragHandler, IEndDragHandler
{

    public int damage;
    public int defense;
    private Image image;
    private Sprite icon;

    public Transform parentAferDrarg;

    private void Start()
    {
        image = GetComponent<Image>();
        icon = image.sprite;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Start drag");
        parentAferDrarg = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        info.Instance.SetInfo(damage,defense,icon);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("draggin");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("stop drag");
        info.Instance.CleanInfo();
        image.raycastTarget = true;
        transform.SetParent(parentAferDrarg);
    }
}
