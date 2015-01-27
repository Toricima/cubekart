using UnityEngine;
using System.Collections;

public class BaseKartClass 
{
	private string characterName;
	private string characterKart;
	private string characterDescription;
	
	//stats
	private int enginePower;
	private int maxSpeed;
	private int turnSpeed;
	
	public string CharacterName
	{
		get{return characterName;}
		set{characterName = value;}
	}
	
	public string CharacterKart
	{
		get{return characterKart;}
		set{characterKart = value;}
	}
	
	public string CharacterDescription
	{
		get{return characterDescription;}
		set{characterDescription = value;}
	}
	
	public int EnginePower
	{
		get{return enginePower;}
		set{enginePower = value;}
	}
	
	public int MaxSpeed
	{
		get{return maxSpeed;}
		set{maxSpeed = value;}
	}
	
	public int TurnSpeed
	{
		get{return turnSpeed;}
		set{turnSpeed = value;}
	}
}
