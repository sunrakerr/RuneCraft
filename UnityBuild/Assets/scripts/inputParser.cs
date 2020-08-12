using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputParser : MonoBehaviour {
    private string[] a;
    
    // Use this for initialization
    void Awake()
    {


    }
  
    public void begininit()
    {
        StartCoroutine(getInput());
        
        Debug.Log(a[0]);
        usernamer.igname = a[0];
        Debug.Log(a[1]);
        coinsrc.coinVal = int.Parse(a[1]);
        Debug.Log(a[2]);
        stats.playerDamage = int.Parse(a[2]);
        Debug.Log(a[3]);
        charscript.speed = int.Parse(a[3]);
    }

    IEnumerator getInput()
    {
        WWW request = new WWW("http://localhost/runescapeconn/inparser.php");
        yield return request;
         a = request.text.Split('\t');

    }
}
