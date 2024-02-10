using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public Rigidbody2D myRb;
    public SpriteRenderer mySprite;
    public float forceAmt = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //will flip the sprite so it's right side up when W is pressed
        if (Input.GetKey(KeyCode.W))
        {
            myRb.AddForce(Vector2.up * forceAmt);
            mySprite.flipY = false;
        }
        
        //will ensure the sprite is facing it's original way, left, when A is pressed
        if (Input.GetKey(KeyCode.A))
        {
            myRb.AddForce(Vector2.left * forceAmt);
            mySprite.flipX = false;
        }
        
        //will flip the sprite's y so it's upside down when S is pressed
        if (Input.GetKey(KeyCode.S))
        {
            myRb.AddForce(Vector2.down * forceAmt);
            mySprite.flipY = true;
        }
        
        //will flip the sprite so it's facing right when D is pressed
        if (Input.GetKey(KeyCode.D))
        {
            myRb.AddForce(Vector2.right * forceAmt);
            mySprite.flipX = true;
        }
        
        myRb.velocity *= 0.999f;
    }
}
