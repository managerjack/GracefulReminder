using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCon : MonoBehaviour
{
    public GameObject ink;
    private GameObject inkCollided;
    private bool draw = true;
    private bool hittingPlayer = false;
    private bool hittingInk = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;     //Hides the cursor in the game
    }

    // Update is called once per frame
    void Update()
    {
        //Converts the mouse position to world point and makes the ink dot position
        //follow the mouse position

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 72.5f;
        transform.position = mousePos;

        //Detects if left mousebutton is pressed or held down

        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
        {
            //Don't draw if the ink dot is overlapping the player or an existing ink

            if (hittingPlayer || hittingInk)
            {
                draw = false;
            }
            else
            {
                draw = true;
            }

            //Makes a copy of the original ink (prefab) and changes the parent to the
            //canvas and the position to the ink dot

            if (draw)
            {
                var inkSpot = Instantiate(ink) as GameObject;
                inkSpot.transform.SetParent(transform.parent);
                inkSpot.transform.position = transform.position;
            }
        }

        //Checks if right mouse button is pressed or held down. Destroy/remove ink
        //thats overlapping the ink dot

        if (Input.GetMouseButton(1) || Input.GetMouseButtonDown(1))
        {
            if (hittingInk)
            {
                Destroy(inkCollided);
            }
        }
    }

    //Collision detection based on the object names attached to the collided objects
    //Checks if collided objects are still inside for each framestep

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name.Contains("Ink"))
        {
            hittingInk = true;
            inkCollided = other.gameObject;
        }

        if (other.name == "Player")
        {
            hittingPlayer = true;
        }
    }

    //Checks if collided objects stepped out of the triggered objects

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.Contains("Ink"))
        {
            hittingInk = false;
        }

        if (other.name == "Player")
        {
            hittingPlayer = false;
        }
    }
}
