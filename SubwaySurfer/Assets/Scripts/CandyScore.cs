using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScore : MonoBehaviour
{
    [SerializeField]

    private float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
        if(transform.position.y < -4.9)
        {
            Reset();
        }
    }

    void Reset() 
        {
            float randomHeight = Random.Range(-5f,7f);
            transform.position = new Vector3(transform.position.x,randomHeight,transform.position.z);
        }

    void OnTriggerEnter2D(Collider2D other)
        {
            //we need to check if we collided with the player
            if(other.tag == "Player")
            {
                //create a reference to the scorekeeper
                ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
                //we need to check if the script was found
                if(scoreKeeper != null)
                {
                    //IncrementScore
                    scoreKeeper.IncrementScore();
                }
                //reset()
                Reset();
            }    
        } 
    
}
