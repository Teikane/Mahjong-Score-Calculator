using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileModel
{
    public SuitEnum suit;
    public ValueEnum value;
    public string tileName;
    public bool redFive = false;
    public bool faceUp = true;

    public TileModel(SuitEnum s, ValueEnum v)
    {
        suit = s;
        value = v;
        tileName = s.ToString() + v.ToString();
    }
    public Sprite GetSprite()
    {
        if (faceUp)
        {
            switch (tileName)
            {
                default:
                case "ManOne": return TileAssets.Instance.manOneSprite;
                case "ManTwo": return TileAssets.Instance.manTwoSprite;
                case "ManThree": return TileAssets.Instance.manThreeSprite;
                case "ManFour": return TileAssets.Instance.manFourSprite;
                case "ManFive": return TileAssets.Instance.manFiveSprite;
                case "ManSix": return TileAssets.Instance.manSixSprite;
                case "ManSeven": return TileAssets.Instance.manSevenSprite;
                case "ManEight": return TileAssets.Instance.manEightSprite;
                case "ManNine": return TileAssets.Instance.manNineSprite;
                case "PinOne": return TileAssets.Instance.pinOneSprite;
                case "PinTwo": return TileAssets.Instance.pinTwoSprite;
                case "PinThree": return TileAssets.Instance.pinThreeSprite;
                case "PinFour": return TileAssets.Instance.pinFourSprite;
                case "PinFive": return TileAssets.Instance.pinFiveSprite;
                case "PinSix": return TileAssets.Instance.pinSixSprite;
                case "PinSeven": return TileAssets.Instance.pinSevenSprite;
                case "PinEight": return TileAssets.Instance.pinEightSprite;
                case "PinNine": return TileAssets.Instance.pinNineSprite;
                case "SouOne": return TileAssets.Instance.souOneSprite;
                case "SouTwo": return TileAssets.Instance.souTwoSprite;
                case "SouThree": return TileAssets.Instance.souThreeSprite;
                case "SouFour": return TileAssets.Instance.souFourSprite;
                case "SouFive": return TileAssets.Instance.souFiveSprite;
                case "SouSix": return TileAssets.Instance.souSixSprite;
                case "SouSeven": return TileAssets.Instance.souSevenSprite;
                case "SouEight": return TileAssets.Instance.souEightSprite;
                case "SouNine": return TileAssets.Instance.souNineSprite;
                case "WindEast": return TileAssets.Instance.windEastSprite;
                case "WindSouth": return TileAssets.Instance.windSouthSprite;
                case "WindWest": return TileAssets.Instance.windWestSprite;
                case "WindNorth": return TileAssets.Instance.windNorthSprite;
                case "DragonRed": return TileAssets.Instance.dragonRedSprite;
                case "DragonWhite": return TileAssets.Instance.dragonWhiteSprite;
                case "DragonGreen": return TileAssets.Instance.dragonGreenSprite;
            }
        }
        else { return TileAssets.Instance.tileBackSprite; }
    }
}
