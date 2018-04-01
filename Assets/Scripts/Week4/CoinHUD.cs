using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinHUD : MonoBehaviour {
    public int coinCount = 0;
    public CoinManage coinManage;
    Text textField;

	// Use this for initialization
	void Start () {
        textField = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        coinCount = 8 - coinManage.GetCoin();
        textField.text = coinCount.ToString();
    }
}
