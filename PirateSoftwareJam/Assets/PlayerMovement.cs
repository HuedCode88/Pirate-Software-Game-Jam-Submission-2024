using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;
    public bool grounded;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize variables
        body = GetComponent<Rigidbody2D>();
    }

    // Basically everything I did here was using Unity's built-in physics engine with RigidBody. It's honestly not THAT hard
    // to make our own if we really wanted to (which would be good for solving issues with how gravity works) but I just did
    // this to save time for now.

    // Update is called once per frame
    void Update()
    {
        // Assigns value based on inputs (either Left/Right Arrow or A/D) of -1 for Left, 0 for None, and 1 for Right.
        // For whatever reason, this is a float, I assume for analog inputs (i.e controllers where you can slightly hold a direction)
        Move = Input.GetAxis("Horizontal");

        // Applies horizontal speed
        body.velocity = new Vector2(speed * Move, body.velocity.y);

        // Checks for input (Spacebar) and applies vertical speed
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            body.AddForce(new Vector2(body.velocity.x, jump));
        }
    }

    // Both of these check if the object is entering/exiting collision with the ground for later use with registering jump inputs
    // Relies on "Ground" tag. Be sure to change tag for any tile that can be jumped off of!
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

}
