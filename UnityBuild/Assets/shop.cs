using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {
    public bool test;
    public GameObject g;
	// Use this for initialization
	void Start () {
        
        test = false;
        g.SetActive(test);
    }
	
	// Update is called once per frame
	void fixedUpdate () {
        inputShop();
	}

    public void inputShop() {
        if (Input.GetKeyDown(KeyCode.B)) {
            test = !test;
            g.SetActive(test);


        }
    }
}
