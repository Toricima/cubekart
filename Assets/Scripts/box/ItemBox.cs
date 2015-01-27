using UnityEngine;
using System.Collections;

public class ItemBox : MonoBehaviour {
	
	BaseItem Item = new BaseItem();
	public string MyItem;
	private int Number;
	
	void OnTriggerEnter(Collider other)
	{
		print ("test");
		if(other.collider.tag == "Kart")
		{
			 //MyItem = Item.GetItem();
		}
			

	}
}
