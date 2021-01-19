using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyInfiniteScroll : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    
 // Start is called before the first frame update
 void Start()
 {
 
 }
 
 // Update is called once per frame
 void Update()
 {
    //Vector3.down = Vector3(-1,0,0)
    //Vector3.down (-7) * 1 * _speed(3) = -3
    transform.Translate(Vector3.down * Time.deltaTime * _speed);
 
 //check the y position of the candy if it is smaller then -75
    if(transform.position.y < -75)
        
 {
 transform.position = new Vector3 (-75,transform.position.y,transform.position.z);
 }
 }
 
 }


