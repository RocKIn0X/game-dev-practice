using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPad : MonoBehaviour {
    public GameObject anotherWarp;
    public bool canWarp;

	// Use this for initialization
	void Start () {
        canWarp = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setAnotherWarp ()
    {
        anotherWarp.GetComponent<WarpPad>().canWarp = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("touch warp");
        if (other.gameObject.tag == "Player" && canWarp)
        {
            print("warp");
            other.transform.position = anotherWarp.transform.position + new Vector3(0f, 0.5f, 0f);
            setAnotherWarp();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("warp");
        if (other.gameObject.tag == "Player")
        {
            canWarp = true;
        }
    }
}
