using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 7f;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.down * Time.deltaTime * speed);
       if(transform.position.y < -6f)
       {
            float random_X = Random.Range(-1f , 1.6f);
            transform.position = new Vector3(random_X,8,transform.position.z);
       }  
    }
}
