using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_draw : MonoBehaviour
{

    public GameObject Man1;
    public GameObject Table;

    public void OnClick()
    {
        for (var i = 0; i < 13; i++)
        {
            GameObject playerTile = Instantiate(Man1, new Vector3(0, 0, 0), Quaternion.identity);
            playerTile.transform.SetParent(Table.transform, false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
