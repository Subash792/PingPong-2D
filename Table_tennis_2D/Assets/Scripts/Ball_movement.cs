using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_movement : MonoBehaviour
{
    public float ball_speed = 10;
    public float hitforce = 0.2f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * ball_speed;
    }

    float factorcalculator(Vector2 ball_pos,Vector2 racket_pos,float rheight)
    {
        return (ball_pos.y - racket_pos.y) / rheight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racketleft")
        {
            // Calculate hit factor
            float y = factorcalculator(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * ball_speed;

        }
        if (collision.gameObject.name == "Racketright")
        {
            // Calculate hit factor
            float y = factorcalculator(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity= dir *ball_speed ;

        }

        


    }

    
    public void reset_ball()
    {
        
        this.transform.position = new Vector2(0f, 0f);
        GetComponent<Rigidbody2D>().velocity = new Vector2(ball_speed, 0);


    }


    
}
