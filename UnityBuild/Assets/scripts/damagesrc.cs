using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class damagesrc : MonoBehaviour {

    public TextMeshProUGUI dmg;
    
    
    // Use this for initialization
    void Start()
    {
        dmg = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        dmg.text = stats.playerDamage.ToString();

    }
}

