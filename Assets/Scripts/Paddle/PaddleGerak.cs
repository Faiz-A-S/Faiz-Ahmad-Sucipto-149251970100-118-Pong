using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleGerak : MonoBehaviour
{
    public float cepatGerak;
    public KeyCode up;
    public KeyCode down;
    public Collider2D ball;
    public int timerKembali;

    private float oldCepatGerak;
    private int turn;
    private Rigidbody2D rig; 
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(turn);
        rig = GetComponent<Rigidbody2D>();
        oldCepatGerak = cepatGerak;
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
        //Debug.Log("Paddle Speed: " + gerak); 
        rig.velocity = gerak; 
    }

    public void ActivatePaddleSpeed(float multiplier)
    {
        cepatGerak += multiplier;
        StartCoroutine("tungguBentar");
    }

    public void ActivatePaddleLong(float multiplier)
    {
        transform.localScale = new Vector3(0.2f, 2+multiplier,1);
        StartCoroutine("tungguBentar");
    }

    IEnumerator tungguBentar()
    {
        yield return new WaitForSeconds(timerKembali);
        Debug.Log("BALIK");
        transform.localScale = new Vector3(0.1f, 2f, 1f);
        cepatGerak = oldCepatGerak;
    }
}
