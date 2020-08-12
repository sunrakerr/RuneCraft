using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class scoresrc : MonoBehaviour {
    public static int scoreValue = 0;
    public TextMeshProUGUI scoreText;
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "" + scoreValue;
	}
}
