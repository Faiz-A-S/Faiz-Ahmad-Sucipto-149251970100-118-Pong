using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaGerak : MonoBehaviour
{
    public Vector2 speed; //nanti bikin random
    private Rigidbody2D rig;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
        rig.velocity = speed; 
    }

    public void ActivatePUSpeedUp(float magnitude) 
    { 
        if(rig.velocity.x <= 13){
           rig.velocity *= magnitude;
        }
    }

    public void ActivateSmallBall(Vector3 multiplier)
    {
        if(transform.localScale.x <= 0.2f){
            transform.localScale -= new Vector3(multiplier.x,multiplier.y); 
        }
    }

    public void ActivateBigBall(Vector3 multiplier)
    {
        transform.localScale += new Vector3(multiplier.x,multiplier.y);
    }
}
