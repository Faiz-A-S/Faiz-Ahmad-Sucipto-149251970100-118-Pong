using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea; 
    public int maxPowerUpAmount; 
    public Vector2 powerUpAreaMin; 
    public Vector2 powerUpAreaMax; 
    public int spawnInterval;
    public int deSpawnInterval;
    public List<GameObject> powerUpTemplateList; 

    private float timer; 
    private float deTimer; 
    private List<GameObject> powerUpList; 
     
    private void Start() 
    { 
        powerUpList = new List<GameObject>(); 
        timer = 0;
        deTimer = 0;
    } 

    private void Update() 
    { 
        timer += Time.deltaTime; 
        deTimer += Time.deltaTime; 

        //Debug.Log(timer);
        //Debug.Log(deTimer);

        if (timer > spawnInterval) 
        { 
            GenerateRandomPowerUp(); 
            timer -= spawnInterval;
        }
        if (deTimer > deSpawnInterval)
        {
            RemoveAllPowerUp();
            deTimer -= deSpawnInterval;
        }
    } 

    public void GenerateRandomPowerUp() 
    { 
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y))); 
    } 
 
    public void GenerateRandomPowerUp(Vector2 position) 
    { 
        if (powerUpList.Count >= maxPowerUpAmount) 
        { 
            return; 
        } 
 
        if (position.x < powerUpAreaMin.x || 
            position.x > powerUpAreaMax.x || 
            position.y < powerUpAreaMin.y || 
            position.y > powerUpAreaMax.y) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, powerUpTemplateList.Count); 
 
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea); 
        powerUp.SetActive(true); 
 
        powerUpList.Add(powerUp); 
    } 
    public void RemovePowerUp(GameObject powerUp) 
    { 
        powerUpList.Remove(powerUp); 
        Destroy(powerUp); 
    } 
 
    public void RemoveAllPowerUp() 
    { 
        if (powerUpList.Count == 2) 
        { 
            RemovePowerUp(powerUpList[0]); 
        }
    } 
}
