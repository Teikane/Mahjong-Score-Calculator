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
public enum ValueEnum { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, East, South, West, North, White, Green, Red };

public class Mahjong : MonoBehaviour
{
    public GameObject tilePrefab;

    public List<Tiles> wall;

    // Start is called before the first frame update
    void Start()
    {
        createWall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static List<Tiles> createWall()
    {
        print("Hello this is a wall");
        List<Tiles> newWall = new List<Tiles>();

        //for man pin and sou
        for (SuitEnum s = SuitEnum.Man; s <= SuitEnum.Sou; s++ )
        {
            //create tiles for each value
            for (ValueEnum v = ValueEnum.One; v <= ValueEnum.Nine; v++)
            {
                //string msg = String.Format("suit {0} value {1}", s, v);
                //print(msg);
                Tiles t = new Tiles();
                t.Suit = s;
                t.Value = v;

                //add tile to the wall four times
                newWall.Add(t);
                newWall.Add(t);
                newWall.Add(t);
                newWall.Add(t);
            }
        }

        // winds
        for (ValueEnum v = ValueEnum.East; v <= ValueEnum.North; v++)
        {
            Tiles t = new Tiles();
            t.Suit = SuitEnum.Wind;
            t.Value = v;

            newWall.Add(t);
            newWall.Add(t);
            newWall.Add(t);
            newWall.Add(t);
        }
        // dragons
        for (ValueEnum v = ValueEnum.White; v <= ValueEnum.Red; v++)
        {
            Tiles t = new Tiles();
            t.Suit = SuitEnum.Dragon;
            t.Value = v;

            newWall.Add(t);
            newWall.Add(t);
            newWall.Add(t);
            newWall.Add(t);
        }

        foreach (Tiles t in newWall)
        {
            string msg = String.Format("suit {0} value {1}", t.Suit, t.Value);
            print(msg);
        }
        return newWall;
    }
}
