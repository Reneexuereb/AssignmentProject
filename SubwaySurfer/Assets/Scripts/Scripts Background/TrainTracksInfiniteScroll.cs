using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainTracksInfiniteScroll : MonoBehaviour
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
        //Vector3.down (-7) * 1 * _speed(3) = -3
        transform.Translate(Vector3.down * Time.deltaTime * _speed);

        //check the y position of the train tracks if it is smaller then -75
        if(transform.position.y < -75)
        {
            if(_randomizeHeight)
            {
                float randomYPosition = Random.Range(-3f,3f);
                Debug.Log("The random position is: " + randomYPosition);
                //teleport  to -75 on the axis
                transform.position = new Vector3(0,-75,randomYPosition);
            }
            else
            {
                transform.position = new Vector3 (-75,transform.position.y,transform.position.z);
            }
        }
        
    }
}

