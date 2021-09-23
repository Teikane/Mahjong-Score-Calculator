using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSlot : MonoBehaviour
{
    public bool Filled { get; set; }
    public GameObject FilledTile { get; set; }

    private void Awake()
    {
        Filled = false;
    }
}
