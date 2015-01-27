using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float enginePower;
	public float turnSpeed;
	
	private float maxSpeed = 30f;
	private Vector3 input;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float RotateSpeed = Input.GetAxis("Horizontal") * turnSpeed;
		float MoveSpeed = Input.GetAxis ("Vertical") * enginePower;
		
		transform.Rotate(0,RotateSpeed * Time.deltaTime,0);
		
		if(MoveSpeed < maxSpeed)
		{
			rigidbody.AddRelativeForce(0,0,MoveSpeed);
		}
		else
		{
			rigidbody.AddRelativeForce(0,0,maxSpeed);
		}
		print("tet");
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Goal")
		{
			
			print("Yea");
		}
	}
}
