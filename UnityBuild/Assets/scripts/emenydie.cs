using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class emenydie : MonoBehaviour {

    [SerializeField]
    public stats health;
    [SerializeField]
    public stats bropow;
    public GameObject prefab;
    private int kill=0;
    private int enehp=20;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("healther"))
        {
            health.MyCurrentValue -= 3;
            
        }
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < 20; i++) 
            { 
                kill=kill+stats.playerDamage; 
               
            }
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;

       
            if (kill > enehp)
            {
                kill = 0;
                gameObject.SetActive(false);
                scoresrc.scoreValue += 5;
                killscr.killsVal += 1;
                coinsrc.coinVal += 2;
                enehp += 5;
                Vector3 pos = new Vector3(Random.Range(-17.0f, 17.0f), Random.Range(-9.0f, 9.0f), -1);
                transform.position = pos;
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                gameObject.SetActive(true);
            }
        }
    }
    
   
}


