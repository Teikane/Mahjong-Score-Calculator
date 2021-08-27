using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprites : MonoBehaviour
{
    public Sprite tileFace;
    public Sprite tileBack;

    private SpriteRenderer spriteRenderer;
    private Mahjong mahjong;

    // Start is called before the first frame update
    void Start()
    {
        //get the mahjong object
        Wall<Tiles> new_wall = new Wall<Tiles>(Mahjong.create_wall());
        mahjong = FindObjectOfType<Mahjong>();

        
        int i = 0;
        foreach (Tiles t in new_wall.wall_of_tiles)
        {
            string t_val = t.suit.ToString() + t.value.ToString();
            if (this.name == t_val)
            {
                tileFace = mahjong.tileFaces[i];
                break;
            }
            i++;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            spriteRenderer.sprite = tileFace;
        }
        else
        {
            spriteRenderer.sprite = tileBack;
        }
    }
}
