using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 resetPosition;

    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2); 
    } 
}
