using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyInfiniteScroll : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private bool _randomizeHeight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.down = Vector3(-1,0,0)
        //Vector3.leftdown (-7) * 1 * _speed(3) = -3
        transform.Translate(Vector3.down * Time.deltaTime * _speed);

        //check the y position of the sky if it is smaller then -73
        if(transform.position.y < -73)
        
            
            else
            {
                transform.position = new Vector3 (73,transform.position.x,transform.position.z);
            }
        }
        
    }
}


