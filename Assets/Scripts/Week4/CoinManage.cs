using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManage : MonoBehaviour {
    public int coin;

	// Use this for initialization
	void Start () {
        coin = transform.childCount;
	}

    void Update()
    {
        coin = transform.childCount;
    }

    public int GetCoin ()
    {
        return coin;
    }
}
