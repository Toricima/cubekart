using UnityEngine;
using System.Collections;

public class PlayerCamara : MonoBehaviour {
	
	public GameObject target;
	private Vector3 offset;
	
	private Vector3 CamaraPosition;
	
	
	// Use this for initialization
	void Start () {
		// de afstand  tussen de camera en de speler.
		offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		
		float desiredAngle = target.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle,0);
		
		// Player postion = (0,0,0)
		// rotation = 90 
		// offset 100
		// ? = 0,0,0 - 90 * 100
		
		transform.position = target.transform.position - ( rotation * offset);
		
		transform.LookAt(target.transform);
	}
	
}
