using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class saveQuit : MonoBehaviour {

   
    void Start() {
                
    }

   
    
    public void savequit() {
        StartCoroutine(sq());
    }

    IEnumerator sq() {
        WWWForm form = new WWWForm();
        form.AddField("coins", coinsrc.coinVal);
        form.AddField("score", scoresrc.scoreValue);
        form.AddField("kills", killscr.killsVal);
        form.AddField("damage", stats.playerDamage);
        form.AddField("speed",charscript.speed);
        form.AddField("name", usernamer.igname);
        WWW www = new WWW("http://localhost/runescapeconn/savequit.php",form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Saved!");
            Application.Quit();
            
        }
        else
        {

            Debug.Log("Could not Save!"+ www.text);
        }
    }

    public void VerifyInputs() {
            
            
            }
	
}
