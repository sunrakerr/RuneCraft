using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class usernamer : MonoBehaviour {
    public TextMeshProUGUI namee;
    public static string igname;
	// Use this for initialization
	void Start () {
        namee = GetComponent<TextMeshProUGUI>();
        
	}
	
	// Update is called once per frame
	void Update () {
        namee.text = igname;
    }

  
}
