using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    

    Rigidbody2D rb;
    int timer;
    int direction;
    
    
    void Start()
    {
        timer = 0;
        direction = 15;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       timer++;

       

       if(timer>200)
       {
            timer = 0;
            direction = -direction;
            rb.velocity = new Vector2(direction,0);
            
       }

    }

}
