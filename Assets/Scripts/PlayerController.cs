using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumpForce;
    public float speed;
    public float bulletSpeed;    
    public float maxSpeed;
    public Rigidbody2D bullet;
    public Rigidbody2D rb;

    private SpriteRenderer mySpriteRenderer;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log(rb.simulated);
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D clone;
            clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;

            if (mySpriteRenderer.flipX)
            {
                clone.velocity = new Vector2(-bulletSpeed, 0);
            }
            if (!mySpriteRenderer.flipX)
            {
                clone.velocity = new Vector2(bulletSpeed, 0);
            }
            //bulletInstance.velocity = new Vector2(speed, 0);
        };

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if(moveHorizontal * rb.velocity.x < maxSpeed)
        {
            rb.AddForce(Vector2.right * moveHorizontal * speed);
   
        }

        if (moveHorizontal < 0 && mySpriteRenderer.flipX == false)
        {
 
            mySpriteRenderer.flipX = true;
        }

        if (moveHorizontal > 0 && mySpriteRenderer.flipX == true)
        {
           
            mySpriteRenderer.flipX = false;
        }
        if (Input.GetKeyDown("space"))
        {
            rb.AddRelativeForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
 
}
