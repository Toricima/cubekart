using UnityEngine;
using System.Collections;

public class BasicKart : BaseKartClass {
	
	public BasicKart()
	{
		CharacterName = "BasicKart";
		CharacterDescription = "Just Basic";
		
		//stats
		EnginePower = 100;
		MaxSpeed = 120;
		TurnSpeed = 50;
		
	}
}
