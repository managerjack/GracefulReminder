using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCon : MonoBehaviour
{
    public static ColorCon instance;
    public Material backgroundImage;
    public SpriteRenderer cursor;
    public SpriteRenderer ink;
    public enum colors { nightForest, ocean, blueSky, end}
    public colors colorState;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
         colorState = colors.blueSky;   //The first level starts with a blue sky, so the color state needs to be
                                        //changed to the blueSky state 
    }

    // Update is called once per frame
    void Update()
    {
        //The backgroundImage, cursor and the ink changes in color based on the current colorState

        if (colorState == colors.blueSky)
        {
            backgroundImage.color = Color.Lerp(backgroundImage.color, new Color(0.2924528f, 1, 1), 0.05f);
            cursor.color = Color.Lerp(cursor.color, Color.green, 0.05f);
            ink.color = Color.Lerp(ink.color, Color.green, 0.05f);

        } else if (colorState == colors.ocean)
        {
            backgroundImage.color = Color.Lerp(backgroundImage.color, new Color(0, 0.1102847f, 0.4056604f), 0.05f);
            cursor.color = Color.Lerp(cursor.color, Color.cyan, 0.05f);
            ink.color = Color.Lerp(ink.color, Color.cyan, 0.05f);

        } else if (colorState == colors.nightForest)
        {
            backgroundImage.color = Color.Lerp(backgroundImage.color, new Color(0, 0.005229969f, 0.1037736f), 0.05f);
            cursor.color = Color.Lerp(cursor.color, Color.yellow, 0.05f);
            ink.color = Color.Lerp(ink.color, Color.yellow, 0.05f);

        } else if (colorState == colors.end)
        {
            backgroundImage.color = Color.Lerp(backgroundImage.color, Color.white, 0.05f);
        }

    }
}
