using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandArea : MonoBehaviour, IDropHandler
{
    GameObject filledTile;
    public List<GameObject> slotsPos;
    private List<GameObject> handTiles = new List<GameObject>();

    int slotsFilled = 0;


    // TO DO: set the position of the tile to the first avaliable slot. Need to determine if slot is filled or empty.
    void Update()
    {
        foreach(GameObject slots in slotsPos)
        {
            foreach (GameObject t in handTiles)
            {
                if (slots.GetComponent<HandSlot>().FilledTile == null)
                {
                    slots.GetComponent<HandSlot>().FilledTile = t;
                }
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (slotsFilled < 14)
        {
            if (eventData.pointerDrag != null)
            {
                // Add Tile Game Object to list of in the game area.
                handTiles.Add(eventData.pointerDrag.gameObject);
                slotsFilled += 1;
                //TODO sort the list when a new tile is added
                //handTiles.Sort();
            }
        }

    }
}
