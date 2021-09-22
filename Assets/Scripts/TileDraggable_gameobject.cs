using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(BoxCollider2D))]


public class TileDraggable_gameobject : MonoBehaviour
{
    // Find any object with BoxCollider has been clicked
    GameObject ReturnClickedObject()
    {
        GameObject target = null;
        Ray ray = main_cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        //check if a collider was hit and return object
        if (hit.collider != null)
        {
            target = hit.collider.gameObject;
        }
        return target;
    }

    GameObject target;
    Camera main_cam;

    Vector3 screenPosition;
    Vector3 offset;
    bool isMouseDrag = false;

    void Start()
    {
        main_cam = Camera.main;
        Debug.Log("Tile Draggable Start");
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            target = ReturnClickedObject();
            if (target != null)
            {
                isMouseDrag = true;
                Debug.Log("target position :" + target.transform.position);
                //Convert world position to screen position.
                screenPosition = main_cam.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - main_cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isMouseDrag = false;
        }

        if (isMouseDrag)
        {
            //track mouse position.
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z);

            //convert screen position to world position with offset changes.
            Vector3 currentPosition = main_cam.ScreenToWorldPoint(currentScreenSpace) + offset;

            //It will update target gameobject's current postion.
            target.transform.position = currentPosition;
        }

    }
}

