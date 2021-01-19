using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 3f;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.down * Time.deltaTime * speed);
       if(transform.position.y < -8f)
       {
           float random_X = Random.Range(-1.5f,1.5f);
           transform.position = new Vector3(random_X,20,transform.position.z);
       }  
    }
}
