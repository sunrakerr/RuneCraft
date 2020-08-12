using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class killscr : MonoBehaviour
{

    public TextMeshProUGUI kills;
    public static int killsVal = 0;
    // Use this for initialization
    void Start()
    {
        kills = GetComponent<TextMeshProUGUI>();
        killsVal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        kills.text = killsVal.ToString();
    }
}
