using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class speedscr : MonoBehaviour {

    public TextMeshProUGUI spd;


    // Use this for initialization
    void Start()
    {
        spd = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        spd.text = charscript.speed.ToString();
    }
}
