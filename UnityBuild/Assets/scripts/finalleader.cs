using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalleader : MonoBehaviour
{
    public static string[] b;
    public static string y;
    
    // Use this for initialization
    public void tester()
    {

        StartCoroutine(test());

    }

    IEnumerator test()
    {
        WWW req = new WWW("http://localhost/runescapeconn/leaderparser.php");
        yield return req;
        b = req.text.Split('\n');
        y = "";
        foreach (string x in b)
        {
            y += (x + "\n");
        }
        
    }
}
