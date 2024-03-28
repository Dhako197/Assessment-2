using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject drooped = eventData.pointerDrag;
            DraggableItem draggableItem = drooped.GetComponent<DraggableItem>();
            draggableItem.parentAferDrarg = transform;
        }
    }

}

