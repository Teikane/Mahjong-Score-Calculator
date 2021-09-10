using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SuitEnum
{
    Man, // Manzu, Characters
    Pin, // Pinzu, Dots
    Sou, // Souzu, Bamboo
    Wind,
    Dragon
}
public enum ValueEnum { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, East, South, West, North, Red, White, Green };

public class TileModel
{
    public SuitEnum suit;
    public ValueEnum value;
    public bool red_five = false;
    public bool face_up = true;

    public TileModel(SuitEnum s, ValueEnum v)
    {
        suit = s;
        value = v;
    }
}

public class Wall<T>
{
    private List<T> _wall_of_tiles;
    public List<T> wall_of_tiles
    { get; set; }

    private List<T> _discard;
    public List<T> discard
    { get; set; }

    public Wall(List<T> tiles)
    {
        this.wall_of_tiles = tiles;
       discard = new List<T>();
    }

    // Draw method
    // Takes in amount of tiles to draw, default 1
    // Returns a List<T> 
    public List<T> Draw( int numberToDraw = 1)
    {
        if (numberToDraw > wall_of_tiles.Count)
            numberToDraw = wall_of_tiles.Count;
        List<T> drawn_tiles = new List<T>();
        for (int i = 0; i < numberToDraw; ++i)
        {
            drawn_tiles.Add(wall_of_tiles[0]);
            wall_of_tiles.RemoveAt(0);
        }
        return drawn_tiles;
    }
}

public class Mahjong : MonoBehaviour
{
    public Sprite[] tileFaces;
    public GameObject tilePrefab;
    public GameObject wallButton;
    public GameObject screen;

    public Wall<TileModel> wall;    

    // Start is called before the first frame update
    void Start()
    {
        game_start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void game_start()
    {
        wall = new Wall<TileModel>( create_wall());


        //print sample of wall
        /*
        List<Tiles> temp = wall.Draw(14);
        foreach (Tiles t in temp)
        { 
            string msg = String.Format("suit {0} value {1}\n", t.Suit, t.Value);
            print(msg);
        }
        */

       Arrange_tiles();

    }

    // create new tile object
    void Arrange_tiles()
    {
        float xOffset = 0;
        float yOffset = 0; 
        float zOffset = 0;

        int i = 0;
        int j = 0;
        foreach ( TileModel t in wall.wall_of_tiles)
        {
            // Instantiate the param1: object to create, param2: the position, param3: oreintation
            GameObject newTile = Instantiate(tilePrefab, new Vector3(wallButton.transform.position.x + xOffset, wallButton.transform.position.y - yOffset, wallButton.transform.position.z - zOffset), Quaternion.identity,screen.transform);
            
            // name the new game object with Suit and value example: Man 1
            newTile.name = t.suit.ToString() + t.value.ToString();

            //stack every 4 of kind
            i++;
            if ((i % 4) == 0)
            {
                xOffset += 2.5f;
                j++;
                // create a new row for every 9 new kind of tile
                if ((j % 9) == 0)
                {
                    xOffset = 0;
                    yOffset += 2.5f;
                }
            }
        }
    }

    public static List<TileModel> create_wall()
    {
        List<TileModel> newWall = new List<TileModel>();

        //for man pin and sou
        for (SuitEnum s = SuitEnum.Man; s <= SuitEnum.Sou; s++ )
        {
            //create tiles for each value
            for (ValueEnum v = ValueEnum.One; v <= ValueEnum.Nine; v++)
            {   
                //add tile to the wall four times
                newWall.Add(new TileModel(s, v));
                newWall.Add(new TileModel(s, v));
                newWall.Add(new TileModel(s, v));
                newWall.Add(new TileModel(s, v));
            }
        }

        // Create 4 of each winds
        for (ValueEnum v = ValueEnum.East; v <= ValueEnum.North; v++)
        {
            newWall.Add(new TileModel(SuitEnum.Wind, v));
            newWall.Add(new TileModel(SuitEnum.Wind, v));
            newWall.Add(new TileModel(SuitEnum.Wind, v));
            newWall.Add(new TileModel(SuitEnum.Wind, v));
        }
        // Create 4 of each dragons
        for (ValueEnum v = ValueEnum.Red; v <= ValueEnum.Green; v++)
        {
            newWall.Add(new TileModel(SuitEnum.Dragon, v));
            newWall.Add(new TileModel(SuitEnum.Dragon, v));
            newWall.Add(new TileModel(SuitEnum.Dragon, v));
            newWall.Add(new TileModel(SuitEnum.Dragon, v));
        }
        return newWall;
    }
    
}
