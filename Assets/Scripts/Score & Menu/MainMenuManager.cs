using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame() 
    { 
        SceneManager.LoadScene("Ingame");
        Debug.Log("Created by Faiz Ahmad Sucipto - 149251970100-118");
    }
}
