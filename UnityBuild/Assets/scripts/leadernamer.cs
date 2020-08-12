using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class leadernamer : MonoBehaviour
{

    public TextMeshProUGUI lead;
    
    // Use this for initialization
    void Start()
    {
       lead= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        lead.text = finalleader.y;
    }
}
