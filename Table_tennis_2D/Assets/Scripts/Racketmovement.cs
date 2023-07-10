using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racketmovement : MonoBehaviour
{
    private float v;
    public float speed = 10;
    public string axis = "Vertical";
    void FixedUpdate()
    {
        v = Input.GetAxis(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
