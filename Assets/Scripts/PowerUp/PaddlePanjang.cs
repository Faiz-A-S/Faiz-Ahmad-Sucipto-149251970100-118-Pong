using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePanjang : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public GameObject paddleKiri;
    public GameObject paddleKanan;
    public BallCarrier script;
    public float multiplier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if(script.carrier == 0){
                paddleKiri.GetComponent<PaddleGerak>().ActivatePaddleLong(multiplier);
                manager.RemovePowerUp(gameObject);
            }else{
                paddleKanan.GetComponent<PaddleGerak>().ActivatePaddleLong(multiplier);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
