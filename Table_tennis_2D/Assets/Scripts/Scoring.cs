using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Scoring : MonoBehaviour
{
    public UnityEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball_movement ball = collision.gameObject.GetComponent<Ball_movement>();

        if (ball != null)
        {
            
            scoreTrigger.Invoke();
        }
    }

}
