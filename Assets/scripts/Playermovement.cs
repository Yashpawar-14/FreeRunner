using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float Sideways = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Sideways * Time.deltaTime, 0, 0 , ForceMode.VelocityChange );
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Sideways * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
