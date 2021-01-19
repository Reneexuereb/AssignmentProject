﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeInfiniteScroll : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;
    // Start is called before the first from update

    void Start() 
    {

    }

    // Update is called once per frame

    void Update()
    {
        //Vector3.down = Vector3(0,-1,0)
        //Vector3.down (-1) * 1 * _speed(3) = -3
        transform.Translate(Vector3.down * Time.deltaTime * _speed);

        //check the y position of the train tracks if it is smaller than -17
        if(transform.position.y < -17)
        {
            //teleport to 17 on the y axis
            transform.position = new Vector3(0,17,0);
        }
       
    }
    
}


