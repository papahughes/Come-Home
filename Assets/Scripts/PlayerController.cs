using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_controller : MonoBehaviour
{
    public Rigidbody2D rb;

    //check if facing right
    bool facingRight = true;

    public float move_speed = 5f;
    Vector2 movement; 


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //movements
        rb.MovePosition(rb.position + movement.normalized * move_speed * Time.fixedDeltaTime);

        //flipping x axis
        if(movement.x > 0 && !facingRight)
        {
            Flip();
        }

        if (movement.x < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
