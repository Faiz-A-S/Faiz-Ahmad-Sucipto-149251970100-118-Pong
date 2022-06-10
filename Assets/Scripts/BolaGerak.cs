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

    // Update is called once per frame
    void Update()
    {
        
    }
}