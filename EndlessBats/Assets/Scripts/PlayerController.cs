using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRidgedbody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    private Animator myAnimator;

	// Use this for initialization
	void Start () {
        myRidgedbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        myRidgedbody.velocity = new Vector2(moveSpeed, myRidgedbody.velocity.y);

        
        if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                myRidgedbody.velocity = new Vector2(myRidgedbody.velocity.x, jumpForce);
            }
        }

        myAnimator.SetFloat("Speed", myRidgedbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
	}
}
