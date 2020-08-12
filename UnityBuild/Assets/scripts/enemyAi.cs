using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAi : MonoBehaviour {

   public GameObject target;
    public float moveSpeed;
    
    public GameObject grill;
    private Vector3 pos;

    private bool right = false;


    // Use this for initialization




    void Start () {
        
         pos = new Vector3(Random.Range(-17.0f,17.0f),Random.Range(-9.0f,9.0f),-1);
        this.transform.position = pos;
        
    }

  // Update is called once per frame
  void Update () {

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        Vector3 vectorToTarget = target.transform.position - transform.position;
        flip(target.transform.localPosition.x,grill.transform.localPosition.x);
          
    }

    
   


    private void flip(float locPos,float mylocPs)
    {
        if (locPos>mylocPs && !right || locPos < mylocPs && right)
        {
            right = !right;
            Vector3 scal = transform.localScale;
            scal.x *= -1;
            transform.localScale = scal;
        }

    }
}
