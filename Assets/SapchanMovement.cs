using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapchanMovement : MonoBehaviour {
    private float inputSpeed = 0f;
    private float running = 2f;
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>(); 		
	}
	
	// Update is called once per frame
	void Update () {
        inputSpeed = Input.GetAxis("Vertical");
        transform.position += this.transform.forward * inputSpeed * Time.deltaTime;
        animator.SetFloat("Speed", inputSpeed);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            inputSpeed = Input.GetAxis("Vertical");
            transform.position += this.transform.forward * inputSpeed * running * Time.deltaTime;
            animator.SetFloat("Speed", inputSpeed);
        }

        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Jump");
        }
	}
}
