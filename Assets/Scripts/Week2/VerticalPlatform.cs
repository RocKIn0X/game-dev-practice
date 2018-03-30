using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour {

    public float ySpeed = 3f;
    public Transform minChild;
    public Transform maxChild;
    private float minY;
    private float maxY;
    private bool moveUp = true;

	void Start () {
        minY = minChild.GetComponent<Transform>().position.y;
        maxY = maxChild.GetComponent<Transform>().position.y;
    }

	void Update () {
        if(moveUp)
        {
            this.transform.position += new Vector3(0f, ySpeed, 0f) * Time.deltaTime;
        } else
        {
            this.transform.position += new Vector3(0f, -ySpeed, 0f) * Time.deltaTime;
        }

        if (this.transform.position.y >= maxY)
        {
            moveUp = false;
        }
        else if (this.transform.position.y <= minY)
        {
            moveUp = true;
        }
    }
}
