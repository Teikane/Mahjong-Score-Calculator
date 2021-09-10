using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileDraggable : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    //Camera main_cam;

    Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        //main_cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}

