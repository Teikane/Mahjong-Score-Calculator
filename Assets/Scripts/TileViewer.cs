using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileViewer : MonoBehaviour
{
    public Sprite tileFace;
    public Sprite tileBack;

    private SpriteRenderer spriteRenderer;
    private Mahjong mahjong;

    private bool faceup=false;

    // Start is called before the first frame update
    void Start()
    {
        //get the mahjong object
        mahjong = FindObjectOfType<Mahjong>();

        int i = 0;
        int j = 0;
        foreach (TileModel t in mahjong.wall.wall_of_tiles)
        {
            string t_val = t.suit.ToString() + t.value.ToString();
            if (this.name == t_val)
            {
                tileFace = mahjong.tileFaces[i];
                this.faceup = t.face_up;
            }
            j++;
            if ((j % 4) == 0)
            {
                i++;
            }
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (faceup==true)
        {
            spriteRenderer.sprite = tileFace;
        }
        else
        {
            spriteRenderer.sprite = tileBack;
        }
    }
}
