using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public GameObject player;
    private float topPoint = 0;

    // Update is called once per frame
    void Update()
    {
        //camera follows player model if it's position is higher than the top point
        if (player.transform.position.y >= topPoint)
        {
            topPoint = player.transform.position.y;
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, topPoint, Camera.main.transform.position.z);
        }
    }
}
