using UnityEngine;
using System.Collections;

public class testGUI : MonoBehaviour {
	
	private BaseKartClass class1 = new DevKart();
	private BaseKartClass class2 = new BasicKart();
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUILayout.Label(class1.CharacterName);
		GUILayout.Label(class1.CharacterDescription);
		
		GUILayout.Label(class2.CharacterName);
		GUILayout.Label(class2.CharacterDescription);
	}
}
