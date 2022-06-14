using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBall : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public Vector3 multiplier;

    private void OnTriggerEnter2D(Collider2D ball){
        Debug.Log("SMALLBALL");
        ball.GetComponent<BolaGerak>().ActivateSmallBall(multiplier);
        manager.RemovePowerUp(gameObject);
    }
}
