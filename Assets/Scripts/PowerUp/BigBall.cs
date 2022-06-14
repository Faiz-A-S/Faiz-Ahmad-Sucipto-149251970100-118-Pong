using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBall : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public Vector3 multiplier;

    private void OnTriggerEnter2D(Collider2D ball){
        Debug.Log("BIGBALL");
        ball.GetComponent<BolaGerak>().ActivateBigBall(multiplier);
        manager.RemovePowerUp(gameObject);
    }
}
