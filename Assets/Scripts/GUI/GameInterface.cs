using UnityEngine;
using System.Collections;

public class GameInterface : MonoBehaviour {
	private int offsetLeft = 20;
	private int offsetHeight = 20;
	
	private int widht = 90;
	private int height = 90;
	
	void OnGUI()
	{	
		
		GUI.BeginGroup(new Rect(0,0,Screen.width / 3, Screen.height));
			GUI.Box(new Rect(offsetLeft,offsetHeight,widht,height), "");
			GUI.Box(new Rect(offsetLeft,Screen.height - 90,70,50), "");
			GUI.Box(new Rect(offsetLeft + 90,Screen.height - 90,widht,50), "");
		GUI.EndGroup();
	}
}
