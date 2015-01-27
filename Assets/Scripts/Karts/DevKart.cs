using UnityEngine;
using System.Collections;

public class DevKart: BaseKartClass
{
	public DevKart()
	{
		CharacterName = "devKart";
		CharacterDescription = "This is the dev kart. Its the most OP kart in the game!!!!";
		
		//stats
		EnginePower = 1000;
		MaxSpeed = 99999;
		TurnSpeed = 1000;
		
	}

}
