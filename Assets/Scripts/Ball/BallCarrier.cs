using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCarrier : MonoBehaviour
{
    public int carrier;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "P1")
        {
            carrier = 0;
        }
        if(collision.gameObject.name == "P2")
        {
            carrier = 1;
        }
    }
}
