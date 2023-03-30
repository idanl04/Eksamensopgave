using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // speed of the player movement

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // get the Rigidbody2D component attached to the player object
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // get the horizontal input (-1, 0, or 1)
        float vertical = Input.GetAxisRaw("Vertical"); // get the vertical input (-1, 0, or 1)

        // normalize the input vector to ensure that diagonal movement is not faster than horizontal/vertical movement
        Vector2 direction = new Vector2(horizontal, vertical).normalized;

        // move the player in the direction specified by the input vector
        rb.velocity = direction * moveSpeed;
    }
}