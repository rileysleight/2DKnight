using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    
    public int lives = 1;
    bool faceLeft = false;
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
 
        
        
        if (Input.GetKey("w"))
        {
            if(velocity.y==0)
            {
                velocity.y = 35;
            }
            
        }
        

        if (Input.GetKey("a"))
        {
            velocity.x = -8.0f;
            faceLeft = true;
        }

        if (Input.GetKey("d"))
        {
            velocity.x = 8f;
            faceLeft = false;
        }



        rb.velocity = velocity;

        if (faceLeft == true)
        {
            transform.localScale = new Vector3(-2,2,2);
        }

        else
        {
            transform.localScale = new Vector3(2,2,2);
        }



        if (Input.GetKey("z"))
        {
            lives = 0;
        }
        









    }
}
