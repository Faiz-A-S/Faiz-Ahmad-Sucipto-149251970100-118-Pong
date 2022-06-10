using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleGerak : MonoBehaviour
{
    public float cepatGerak;
    public KeyCode up;
    public KeyCode down;
    private Rigidbody2D rig; 
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //get input
        //update posisi paddle
        MoveObject(GetInput());
    }

    // get input 
    private Vector2 GetInput(){
        if (Input.GetKey(up))
        { 
            // ke atas
            return Vector2.up * cepatGerak;
        } 
        if (Input.GetKey(down))
        { 
            // ke bawah 
            return Vector2.down * cepatGerak;
        } 
        return Vector2.zero;
    }

    //update posisi paddle
    private void MoveObject(Vector2 gerak){
        Debug.Log("Paddle Speed: " + gerak); 
        rig.velocity = gerak; 
    }
}
