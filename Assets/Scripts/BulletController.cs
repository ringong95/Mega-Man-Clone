using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //if (direction == 1)
        //{
        //    rb.AddForce(Vector2.right * speed);
        //}
           
    }
}
