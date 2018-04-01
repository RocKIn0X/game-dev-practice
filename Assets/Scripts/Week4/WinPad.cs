using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPad : MonoBehaviour {
    public GameObject victoryPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            victoryPanel.SetActive(true);
        }
    }
}
