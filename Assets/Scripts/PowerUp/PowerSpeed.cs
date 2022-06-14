using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : MonoBehaviour
{
    public Collider2D ball; 
    public float magnitude; 
    public PowerUpManager manager;
 
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball) 
        { 
        Debug.Log("SPEEDBALL");
        // Speed Up the ball 
        ball.GetComponent<BolaGerak>().ActivatePUSpeedUp(magnitude); 
        manager.RemovePowerUp(gameObject);
        }
    } 
}
