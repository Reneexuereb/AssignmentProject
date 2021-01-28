using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("The player has entered obstacle mode");
        //reload the scene when the player hits the obstacles
        SceneManager.LoadScene(0);
    }
}
