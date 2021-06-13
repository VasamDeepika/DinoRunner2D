using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrock : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float playerSpeed;
    SpriteRenderer playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    //left arrow to move left and right arrow to move right
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRB.velocity = Vector2.right * playerSpeed;
            playerSprite.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRB.velocity = -Vector2.right* playerSpeed;
            playerSprite.flipX = true;
        }
    }
}
