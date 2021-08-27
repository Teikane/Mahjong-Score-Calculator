using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//is this needed?
public class Tile : MonoBehaviour
{
    private SuitEnum _suit;
    public SuitEnum suit
    { get; set; }

    private ValueEnum _value;
    public ValueEnum value
    { get; set; }

    public Tile(SuitEnum s, ValueEnum v)
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

    // Start is called before the first frame update
    void Start()
    {
        print("Hello this Tile Object");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
