using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAssets : MonoBehaviour
{
    public static TileAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite tileBackSprite;
    public Sprite manOneSprite;
    public Sprite manTwoSprite;
    public Sprite manThreeSprite;
    public Sprite manFourSprite;
    public Sprite manFiveSprite;
    public Sprite manFiveRedSprite;
    public Sprite manSixSprite;
    public Sprite manSevenSprite;
    public Sprite manEightSprite;
    public Sprite manNineSprite;
    public Sprite pinOneSprite;
    public Sprite pinTwoSprite;
    public Sprite pinThreeSprite;
    public Sprite pinFourSprite;
    public Sprite pinFiveSprite;
    public Sprite pinFiveRedSprite;
    public Sprite pinSixSprite;
    public Sprite pinSevenSprite;
    public Sprite pinEightSprite;
    public Sprite pinNineSprite;
    public Sprite souOneSprite;
    public Sprite souTwoSprite;
    public Sprite souThreeSprite;
    public Sprite souFourSprite;
    public Sprite souFiveSprite;
    public Sprite souFiveRedSprite;
    public Sprite souSixSprite;
    public Sprite souSevenSprite;
    public Sprite souEightSprite;
    public Sprite souNineSprite;
    public Sprite windEastSprite;
    public Sprite windSouthSprite;
    public Sprite windWestSprite;
    public Sprite windNorthSprite;
    public Sprite dragonRedSprite;
    public Sprite dragonWhiteSprite;
    public Sprite dragonGreenSprite;

}
