using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle; 
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstacleWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(obstacle) as GameObject;
    }
    IEnumerator obstacleWave()
    {
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        } 
    } 
}
