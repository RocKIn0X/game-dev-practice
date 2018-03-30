using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour {
    Text textField;
    public Rigidbody target;

	// Use this for initialization
	void Start () {
        textField = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        textField.text = target.velocity.magnitude.ToString();
	}
}
