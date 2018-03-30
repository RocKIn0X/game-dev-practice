using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //print(Input.GetAxisRaw("Horizontal"));
        if(Input.GetButtonDown("Fire1"))
        {
            print("Fire1 is down.");
        }
        if (Input.GetButton("Fire1"))
        {
            print("Fire1 is hold.");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            print("Fire1 is up.");
        }
    }
}
