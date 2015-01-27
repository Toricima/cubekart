using UnityEngine;
using System.Collections;
using System;

public class BaseItem
{
	public string itemName{get; protected set;}
	public string itemDescription{get; protected set;}
	
 	public enum ItemList
	{
		//speed
		Mushroom,
		TripleMushroom,
		GoldenMushroom,
		Bullet,
		Lighting,
		star,
		
		//projectiles
		GreenShell,
		TripleGreenShell,
		
		RedShell,
		TripleRedShell,
		
		BlueShell,
		
		Banana,
		TripleBanana,
		
		Bobomb,
		
	}
	
	public void GetItem()
	{
	 	System.Random r = new System.Random();
//		itemName = ((ItemList)(r.Next(1,5))).ToString;
		
		//Debug.Log(itemName);
	}
		
}
