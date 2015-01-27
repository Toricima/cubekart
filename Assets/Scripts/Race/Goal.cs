using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	
	private FirstMap map = new FirstMap();
	private int currentLap = 1;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.collider.tag == "Kart")
		{
			currentLap++;
			print("Lap has been added" + currentLap);
			
			if(currentLap == map.laps)
			{
				print("You have won the race!");
			}
			
		}	
	}
}
