using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

    public float maxHp = 100f;
    public float currentHp = 100f;
    public Slider hpBar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hpBar.value = currentHp / maxHp;
	}
}
