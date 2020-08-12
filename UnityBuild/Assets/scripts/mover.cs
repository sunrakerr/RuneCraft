using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mover : charscript {
	protected Joystick joystick;
	private bool right=true;

[SerializeField]
	public stats health;
[SerializeField]
	public stats bropow;
	private float maxHealth = 100;
	private float maxBropow = 100;
	protected override void Start () {
		health.Initialise(maxHealth,maxHealth);
		bropow.Initialise(maxBropow,maxBropow);
		base.Start();
		joystick = FindObjectOfType<Joystick>();
	
	}
	
	
	protected override void Update () {
		float horizontal  = Input.GetAxis("Horizontal");
		keyinp();
		base.Update();
		flip(horizontal);
		
	}
	private void flip(float horizontal){
		if(horizontal>0 && !right || horizontal<0 && right)
		{
			right = !right;
			Vector3 scal = transform.localScale;
			scal.x *= -1;
			transform.localScale = scal;
		}

	}

     


    public void keyinp()
	{
			direction = Vector2.zero;

			if(Input.GetKey(KeyCode.I))
			{
			health.MyCurrentValue -=1;	
			bropow.MyCurrentValue -=1;
			}
			if(Input.GetKey(KeyCode.O))
			{
			health.MyCurrentValue +=1;	
			bropow.MyCurrentValue +=1;	
			}
        if (health.MyCurrentValue < 1) {
            SceneManager.LoadScene(2);
        }

			

			if(Input.GetKey(KeyCode.W)||(joystick.handle.localPosition.y > 9))
			{
				direction += Vector2.up;	
			}
			if(Input.GetKey(KeyCode.A)||(joystick.handle.localPosition.x < -9))
			{
				direction += Vector2.left;	
			}

			if(Input.GetKey(KeyCode.S)||(joystick.handle.localPosition.y < -9))
			{
				direction += Vector2.down;
			}

			if(Input.GetKey(KeyCode.D)||(joystick.handle.localPosition.x > 9))
			{
				direction += Vector2.right;
			}


	}
	
}
