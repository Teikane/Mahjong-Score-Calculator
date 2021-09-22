using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class calc_field : MonoBehaviour, IDropHandler
{
    GameObject filled_tile;
    public bool slot_filled = false;

    // TO DO: figure out why OnDrop requires a fast moving drop to register. Figure out how to undo slot filled when dragging obejct away
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            filled_tile = eventData.pointerDrag;

            if (slot_filled == false)
            { 
                eventData.pointerDrag.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
                
                slot_filled = true;
            }

        }
    }
}
