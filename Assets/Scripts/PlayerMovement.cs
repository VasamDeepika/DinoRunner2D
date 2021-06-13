using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float jumpVelocity;
    bool grounded = true;
    Animator animator;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (grounded)
            {
                Jump();
                animator.SetTrigger("Jump");
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        if(collision.gameObject.tag == "Obstacle")
        {
            animator.SetTrigger("Dead");
            canvas.gameObject.SetActive(true);
        }
    }
    private void Jump()
    {
        grounded = false;
        playerRB.velocity = new Vector2(0, jumpVelocity);
    }
}
