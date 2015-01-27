using UnityEngine;
using System.Collections;

public class BaseItemSpeedBoost : BaseItem
{
	public float speedBoost{get; protected set;}
	
	//Bullet bill and golden muschroom
	public float boostDuration{get; protected set;}
	
	void CalcBoostDuration(float duration)
	{
		
		this.boostDuration = duration * Time.deltaTime;
	}
	
}
