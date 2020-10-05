using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
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
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
    



        float xSpeed = -10.0f;
        //float ySpeed = 10.0f;

        if (Input.GetKey("left"))
        {

            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(-xSpeed * Time.deltaTime, 0, 0);
        }

        //if (Input.GetKey("up"))
        //{
        //    transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
        //}

        //if (Input.GetKey("down"))
        //{
        //    transform.position += new Vector3(0, -ySpeed * Time.deltaTime, 0);
        //}



        if (Input.GetKey("x"))
        {
            lives = 0;
        }

    }
}
