using UnityEngine;
using System.Collections;

public class TestBoxScript : MonoBehaviour {
	
	private int Number;
	
	void OnTriggerEnter(Collider other)
	{
		print ("test");
		if(other.collider.tag == "Kart")
		{
			print("bitch!");
			Number = Random.Range(0,13);	
			//Item.GetItem(Number);
			
			Debug.Log(Number);
		}
			

	}
}
