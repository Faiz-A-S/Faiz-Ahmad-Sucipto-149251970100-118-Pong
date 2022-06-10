using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri; 
    public Text skorKanan; 
    public ScoreManager manager; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update() 
    { 
        skorKiri.text = manager.leftScore.ToString(); 
        skorKanan.text = manager.rightScore.ToString(); 
    }
}
