using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float turnSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        //make sure coin does not spawn inside obstacles
        if(other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }
        

        if(other.gameObject.name == "Player")
        {
            GameManager.inst.IncrementScore();
            //destroy coin when collided with player
            Destroy(gameObject);
        }
        
    }
}
