using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeed : MonoBehaviour
{
    public Collider2D ball;
    GameObject paddle;
    public PowerUpManager manager;
    public float multiplier;

    void Start(){
        //paddle = GameObject.FindWithTag("Paddle");
        //Destroy(paddle);
    }

    private void OnTriggerEnter2D(Collider2D ball){
        Debug.Log("PADDLESPEED");
        paddle.GetComponent<PaddleGerak>().ActivatePaddleSpeed(multiplier);
        manager.RemovePowerUp(gameObject);
    }
}
