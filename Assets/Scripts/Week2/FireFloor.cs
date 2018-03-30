using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFloor : MonoBehaviour {
    public Transform checkPoint;

    private void OnCollisionEnter(Collision collision)
    {
        print("Hit");
        if (collision.gameObject.name == "RigidBodyFPSController")
        {
            collision.transform.position = checkPoint.position;
            collision.rigidbody.velocity = Vector3.zero;
        }
    }
}
