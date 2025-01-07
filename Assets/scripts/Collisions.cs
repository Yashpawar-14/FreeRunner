using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Playermovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacal")
        {
           movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
