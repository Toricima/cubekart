using UnityEngine;
using System.Collections;

public class DashShroom : BaseItemSpeedBoost {
	
	public GameObject Kart;
	
	public DashShroom(): base()
	{
		this.itemName = "Dash Mushroom";
		this.itemDescription = "This Item gives you an amazing speed boost!";
		this.speedBoost = 1000;
	}
	
	public void OnActivate()
	{
		Kart.rigidbody.AddRelativeForce(0,0,this.speedBoost);
	}
		
}
