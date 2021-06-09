using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //setting boundaries around the edges of the camera
        BoxCollider2D leftBound = gameObject.AddComponent<BoxCollider2D>();
        BoxCollider2D rightBound = gameObject.AddComponent<BoxCollider2D>();
        BoxCollider2D bottomBound = gameObject.AddComponent<BoxCollider2D>();

        leftBound.offset = new Vector2(-Camera.main.orthographicSize * Screen.width / Screen.height, 0);
        rightBound.offset = new Vector2(Camera.main.orthographicSize * Screen.width / Screen.height, 0);
        bottomBound.offset = new Vector2(0, -Camera.main.orthographicSize);

        leftBound.size = new Vector2(0.1f, Camera.main.orthographicSize * 2);
        rightBound.size = new Vector2(0.1f, Camera.main.orthographicSize * 2);
        bottomBound.size = new Vector2(Camera.main.orthographicSize * Screen.width / Screen.height * 2, 0.1f);
    }
}
