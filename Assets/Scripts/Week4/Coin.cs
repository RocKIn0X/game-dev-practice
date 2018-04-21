using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    public float score = 1;
    public Collider collide;
    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Hit");
            animator.SetTrigger("IsCollected");
            //collide.enabled = false;
        }
    }
}
