using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemScript : MonoBehaviour {
    public stats health;
    public stats mana;
    public Animator anim;
  
    
    public static int speedcost = 12;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void initateItem() {
        Text t = transform.Find("itemName").GetComponent<Text>();
        

        if (t.text.Equals("HealingSalve")) {
            if (health.MyCurrentValue < 100)
            {
                if (coinsrc.coinVal >= 10)
                {
                    
                    coinsrc.coinVal -= 10;
                    health.MyCurrentValue += 20;
                    
                }
            }
            
        }

        if (t.text.Equals("Mana")) {

            if (mana.MyCurrentValue < 100)
            {
                if (coinsrc.coinVal >= 10)
                {
                    coinsrc.coinVal -= 10;
                    mana.MyCurrentValue += 10;
                    
                }
            }
        }
        if (t.text.Equals("HealKit")) {

            if (health.MyCurrentValue < 100)
            {
                if (coinsrc.coinVal >= 30)
                {
                    coinsrc.coinVal -= 30;
                    health.MyCurrentValue += 100;
                   
                }
            }
        }

        if (t.text.Equals("AllKill")) {
            if (coinsrc.coinVal >= 1) {

                coinsrc.coinVal -= 1;
                anim.SetTrigger("explode");
              
            }
        }

        if (t.text.Equals("+1 Damage")) {
            if (coinsrc.coinVal >= 7) {
                coinsrc.coinVal -= 7;
                costdmg.dmgcost += 7;
                
                stats.playerDamage += 1;
                
            }
        }

        if (t.text.Equals("+1 Speed"))
        {
            if (coinsrc.coinVal >= 12)
            {
                coinsrc.coinVal -= 12;
                costspd.spdcost += 12;
                
                charscript.speed += 1;
                
            }
        }




    }
}
