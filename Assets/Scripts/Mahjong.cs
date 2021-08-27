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

public class Tiles
{
    private SuitEnum _suit;
    public SuitEnum suit
    { get; set; }

    private ValueEnum _value;
    public ValueEnum value
    { get; set; }

    public Tiles(SuitEnum s, ValueEnum v)
    {
        suit = s;
        value = v;
    }

    private bool _red_five;
    public bool red_five
    { get; set; }

    private bool _face_up = false;
    public bool face_up
    { get; set; }
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


    private Wall<Tiles> _wall;
    public Wall<Tiles> wall
    { get; set; }
    


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
        wall = new Wall<Tiles>( create_wall());


        //print sample of wall
        /*
        List<Tiles> temp = wall.Draw(14);
        foreach (Tiles t in temp)
        { 
            string msg = String.Format("suit {0} value {1}\n", t.Suit, t.Value);
            print(msg);
        }
        */
    }

    public static List<Tiles> create_wall()
    {
        List<Tiles> newWall = new List<Tiles>();

        //for man pin and sou
        for (SuitEnum s = SuitEnum.Man; s <= SuitEnum.Sou; s++ )
        {
            //create tiles for each value
            for (ValueEnum v = ValueEnum.One; v <= ValueEnum.Nine; v++)
            {   
                //add tile to the wall four times
                newWall.Add(new Tiles(s, v));
                newWall.Add(new Tiles(s, v));
                newWall.Add(new Tiles(s, v));
                newWall.Add(new Tiles(s, v));
            }
        }

        // Create 4 of each winds
        for (ValueEnum v = ValueEnum.East; v <= ValueEnum.North; v++)
        {
            newWall.Add(new Tiles(SuitEnum.Wind, v));
            newWall.Add(new Tiles(SuitEnum.Wind, v));
            newWall.Add(new Tiles(SuitEnum.Wind, v));
            newWall.Add(new Tiles(SuitEnum.Wind, v));
        }
        // Create 4 of each dragons
        for (ValueEnum v = ValueEnum.White; v <= ValueEnum.Red; v++)
        {
            newWall.Add(new Tiles(SuitEnum.Dragon, v));
            newWall.Add(new Tiles(SuitEnum.Dragon, v));
            newWall.Add(new Tiles(SuitEnum.Dragon, v));
            newWall.Add(new Tiles(SuitEnum.Dragon, v));
        }
        return newWall;
    }
    
}
