using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinsrc : MonoBehaviour {

        public TextMeshProUGUI Coin;
    public static int coinVal=0;
	// Use this for initialization
	void Start () {
        Coin = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
        Coin.text =  coinVal.ToString(); 
	}
}
