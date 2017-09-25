using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRidgedbody;

	// Use this for initialization
	void Start () {
        myRidgedbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        myRidgedbody.velocity = new Vector2(moveSpeed, myRidgedbody.velocity.y);
        
        if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            myRidgedbody.velocity = new Vector2(myRidgedbody.velocity.x, jumpForce);
        }
	}
}
