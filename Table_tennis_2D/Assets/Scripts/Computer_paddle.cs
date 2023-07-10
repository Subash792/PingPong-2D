using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer_paddle : MonoBehaviour
{
    public Rigidbody2D ball;
    private float force= 10;
    private Rigidbody2D paddle;


    private void Start()
    {
        paddle = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {


         if (ball.velocity.x < 0)
        {
            if (ball.position.y > transform.position.y)
            {
                paddle.AddForce(Vector2.up * force);
            }
            else if(ball.position.y < transform.position.y)
            {
                paddle.AddForce(Vector2.down * force);

            
            }
        }
        else{

            if (transform.position.y<0f)
            {
                paddle.AddForce(Vector2.up * force);
            }
            else if (transform.position.y>0f)
            {
                paddle.AddForce(Vector2.down * force);


            }
        }

        

        
    }

}
