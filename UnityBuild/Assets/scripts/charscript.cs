using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  charscript : MonoBehaviour {

	[SerializeField]
	public static int speed=3;
	protected Vector2 direction;
		public Animator animator;
    private camshake shake;
    private bool attacking;
    
	protected virtual void Start () {
		animator = GetComponent<Animator>();
        shake = GameObject.FindGameObjectWithTag("camshaker").GetComponent<camshake>();
        
        
	}
	

	protected virtual void Update () {
		Move();
        handInp();
        
       
	}
	public void Move()
	{
		transform.Translate(direction*speed*Time.deltaTime);

		if(direction.x!=0 || direction.y!=0)
		{
            animator.SetFloat("speed", Mathf.Abs(1));
		}
		else{
            animator.SetFloat("speed", Mathf.Abs(0));
        }
	
		
	}
    private void handleAttack()
    {
        
    }

    private void handInp(){
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetBool("attack", true);
            shake.camShake();

        }

      

        else
        {
            animator.SetBool("attack", false);
        }
        
    }

    private void reset() {
        attacking = false;
    }


	public void powe()
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			animator.Play("Bro_force1");
			
		}


	}

	
	


	
}
