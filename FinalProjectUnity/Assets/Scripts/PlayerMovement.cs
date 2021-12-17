using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 10;

    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector3 vel = new Vector3();

        vel.x = h * speed;
        vel.y = rb.velocity.y;
        vel.z = 0;

        if (Input.GetButtonDown("Jump"))
        {
            vel.y = jumpForce;
        }

        rb.velocity = vel;
    }
}
