using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class costspd : MonoBehaviour {
    public static int spdcost = 12;
    public Text p;
	// Use this for initialization
	void Start () {
        p = GetComponent<Text>();
        spdcost = 12;
    }
	
	// Update is called once per frame
	void Update () {
        p.text = spdcost.ToString();
	}
}
