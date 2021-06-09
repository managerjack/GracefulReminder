using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerCon : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //player model moves left on 'A'-key press
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Vector2.right * 30.0f);
        }

        //player model moves right on 'D'-key press
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * 30.0f);
        }

        //player model jumps on 'W'-key press and collision with ink
        if (Input.GetKeyDown(KeyCode.W) && jump)
        {
            rb.AddForce(Vector2.up * 50.0f, ForceMode2D.Impulse);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name.Contains("Ink"))
        {
            jump = true;
        }    
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.Contains("Ink"))
        {
            jump = false;
        }
    }
}
