using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour {
    public Vector3 jumpForce;

    void OnTriggerEnter(Collider other)
    {
        print("Jump");
        if (other.gameObject.name == "RigidBodyFPSController")
        {
            other.GetComponent<Rigidbody>().AddForce(jumpForce, ForceMode.Impulse);
        }
    }
}
