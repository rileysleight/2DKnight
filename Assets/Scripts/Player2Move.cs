using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{

    public int lives = 1;




    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
 
        
        
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = velocity;
            velocity.y = 15;
        }
        

        if (Input.GetKey("a"))
        {
            rb.velocity = velocity;
            velocity.x = -15;
        }

        if (Input.GetKey("d"))
        {
            rb.velocity = velocity;
            velocity.x = 15;
        }




        if (Input.GetKey("z"))
        {
            lives = 0;
        }

    }
}
