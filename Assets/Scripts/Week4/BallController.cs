using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private Rigidbody selfRigid;
    public float moveForce = 10f;
    public float jumpForce = 5f;
    public float maxSpeed = 10f;
    public LayerMask interestLayer;

    bool isOnGround = false;

	// Use this for initialization
	void Start () {
        selfRigid = GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        // normalize every axis for gaurantee every speed are equal
        moveDirection.Normalize();
        //print(moveDirection);
        selfRigid.AddForce(moveDirection * moveForce);

        if (Input.GetButtonDown("Jump") && isOnGround)
        {
                selfRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
        }

        if (selfRigid.velocity.magnitude > maxSpeed)
        {
            //use normal vector multiply by max speed for limit speed
            selfRigid.velocity = selfRigid.velocity.normalized * maxSpeed;
        }
    }

    // Update is called once per frame
    void Update () {
        bool isRayHitSomething = false;

        RaycastHit castHit;
        if (Physics.Raycast(this.transform.position, Vector3.down, out castHit, 0.6f, interestLayer.value))
        {
            isRayHitSomething = true;
            isOnGround = true;
            print(castHit.collider.name);
        }
        else
        {
            isOnGround = false;
        }
        
        // Hit change color line
        if (isRayHitSomething)
        {
            Debug.DrawLine(this.transform.position, this.transform.position + Vector3.down * 0.6f, Color.red);
        }
        else
        {
            Debug.DrawLine(this.transform.position, this.transform.position + Vector3.down * 0.6f, Color.green);
        }

        // using Physics.BoxCast for solve when you are edge and raycast line not through plane. Boxcast has more space to through than ray cast. 
    }
}
