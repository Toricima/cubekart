using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		/*
		GUI.BeginGroup(new Rect(Screen.width / 2 -50,Screen.height /2 -50, 100,100));
		
		if(GUI.Button(new Rect(20,30,80,20),"hello"))
		{
			
			Debug.Log ("button has been clicked");
			Application.LoadLevel(1);
		}
		
		GUI.EndGroup();
		*/
		
		GUI.BeginGroup(new Rect(0 , 0, 100, 30));
		
		//draw the background images
		
		
		
		GUI.EndGroup();
	}
}
