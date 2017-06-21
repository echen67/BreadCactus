using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMovement : MonoBehaviour {

//    public enum PlayerType
//    {
//        Bread, Cactus
//    }

    //public PlayerType playerType;	//this will need to be seen by other scripts
    private KeyCode leftKey;
    private KeyCode rightKey;
    private KeyCode upKey;
    private KeyCode downKey;
	public void setKeys(KeyCode left, KeyCode right, KeyCode up, KeyCode down) {
		leftKey = left;
		rightKey = right;
		upKey = up;
		downKey = down;
	}

    public float speed = 5f;
    public float jump = 5f;

    private bool grounded;
	private float raycastLength;  //cactus is taller than bread, so it will need a longer raycast length
	public void setRaycastLength(float input) {
		raycastLength = input;
	}

    private bool currentDirection = false;  //left is false, right is true
    private bool newDirection = false;

    private Rigidbody2D rbody;

    void Awake () {
//		if (playerType == PlayerType.Bread)
//        {
//            leftKey = KeyCode.A;
//            rightKey = KeyCode.D;
//            upKey = KeyCode.W;
//            downKey = KeyCode.S;
//            raycastLength = 2.3f;
//        } else
//        {
//            leftKey = KeyCode.LeftArrow;
//            rightKey = KeyCode.RightArrow;
//            upKey = KeyCode.UpArrow;
//            downKey = KeyCode.DownArrow;
//            raycastLength = 3.2f;
//        }

        rbody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        //Change direction based on the last key (left or right) pressed
        if (currentDirection != newDirection)
        {
            transform.Rotate(new Vector3(0, -180, 0));
            currentDirection = newDirection;
        }

        Walk();
        Jump();
	}

    private void CheckGrounded()
    {
        //Vector3 end = new Vector3(transform.position.x, transform.position.y - 2.3f, 0);
        //Debug.DrawLine(transform.position, end, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastLength);
        if (hit.collider != null && hit.collider.tag == "Platforms")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    private void Walk()
    {
        if (Input.GetKey(leftKey))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);
            newDirection = false;
        }
        if (Input.GetKey(rightKey))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);
            newDirection = true;
        }
    }

    private void Jump()
    {
        CheckGrounded();
        if (Input.GetKeyDown(upKey) && grounded)
        {
			Debug.Log ("Jump");
            rbody.velocity = Vector2.up * jump;
        }
    }
}
