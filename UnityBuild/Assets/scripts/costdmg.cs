using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class costdmg : MonoBehaviour {


    public Text t;
    public static int dmgcost = 7;
	// Use this for initialization
	void Start () {
         t = GetComponent<Text>();
        dmgcost = 7;
    }
	
	// Update is called once per frame
	void Update () {
        t.text = dmgcost.ToString();
	}
}
