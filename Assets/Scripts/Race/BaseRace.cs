using UnityEngine;
using System.Collections;

public class BaseRace
{
	public string Name{get; protected set;}
	public int laps{get; protected set;}
	public int Players{get; protected set;}
	
	public BaseRace(string name)
	{
		this.Name = name;
	}
}
