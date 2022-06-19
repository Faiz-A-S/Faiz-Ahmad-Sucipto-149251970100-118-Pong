using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuManager : MonoBehaviour
{
    private void Update()
    {
        Listener();
    }
    public void Listener()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    public void PlayGame() 
    { 
        SceneManager.LoadScene("Ingame");
        Debug.Log("Created by Faiz Ahmad Sucipto - 149251970100-118");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PlayCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
