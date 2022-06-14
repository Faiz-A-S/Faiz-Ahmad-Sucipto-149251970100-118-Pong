using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 resetPosition;
    public Vector2 resetSpeed;
    public Vector3 resetScale;

    public Rigidbody2D ball;

    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        ball.velocity = new Vector2(resetSpeed.x, resetSpeed.y);
        transform.localScale = new Vector3(resetScale.x, resetScale.y);
    } 
}
