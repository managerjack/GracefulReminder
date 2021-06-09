using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLineCon : MonoBehaviour
{
    private BoxCollider2D endCol;
    private Color playerColor;
    private Color endTextColor;
    public SpriteRenderer cursor;
    public SpriteRenderer ink;
    public SpriteRenderer player;
    public Text endgameText;

    // Start is called before the first frame update
    void Start()
    {
        //set collider for the object to be the screen width
        endCol = GetComponent<BoxCollider2D>();
        endCol.size = new Vector2(Display.main.systemWidth, endCol.size.y);

        endTextColor = endgameText.color;
    }

    // Update is called once per frame
    void Update()
    {
        //check if player has reached the end of game
        if (ColorCon.instance.colorState == ColorCon.colors.end && playerColor != null)
        {
            //decrease the alpha level of sprites for playermodel, cursor and ink 
            playerColor = new Color(playerColor.r, playerColor.g, playerColor.b, playerColor.a - Time.deltaTime * 5.0f);
            cursor.color = new Color(cursor.color.r, cursor.color.g, cursor.color.b, cursor.color.a - Time.deltaTime * 5.0f);
            ink.color = new Color(ink.color.r, ink.color.g, ink.color.b, ink.color.a - Time.deltaTime * 5.0f);
            player.color = playerColor;

            //when player model sprite is transparent, showcase the endgame text
            if (playerColor.a <= 0)
            {
                endgameText.enabled = true;
                endTextColor = new Color(endTextColor.r, endTextColor.g, endTextColor.b, endTextColor.a + Time.deltaTime * 5.0f);
                endgameText.color = endTextColor;
            }
        }

        //when the endtext object's alpha level reaches a certain number, restart game 
        if (endTextColor.a >= 40)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //get player model color when collided
        if (other.name == "Player")
        {
            player.color = other.GetComponent<SpriteRenderer>().color;
            playerColor = player.color;
            endCol.enabled = false;
        }
    }
}
