using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stats : MonoBehaviour {

	private Image content;
	[SerializeField]
	private Text statValue;
	private float currentFill;
    public static int Pcoins=0;
    public static int Pscore=0;
    public static int playerDamage = 1;
	public float MyMaxValue { get;set;}
	private float currentValue;
	[SerializeField]
	private float lerpSpeed;
	public float MyCurrentValue{

	get
	{
		return currentValue;
	}
	set
	{
		if(value>MyMaxValue)
		{
			currentValue = MyMaxValue;
		}
		else if (value<0)
		{
			currentValue = 0;
		}
		else{
			currentValue = value;
		}
		currentFill = currentValue/MyMaxValue;
		statValue.text = currentValue + "/" + MyMaxValue;
	}
	}

	
	void Start () {
		
		content = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(currentFill !=content.fillAmount)
		{
			content.fillAmount = Mathf.Lerp(content.fillAmount,currentFill,Time.deltaTime*lerpSpeed);
		}
	
	}

	public void Initialise(float currentValue,float maxValue)
	{
		MyMaxValue = maxValue;
		MyCurrentValue = currentValue;
	}
}
