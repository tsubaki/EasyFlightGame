using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class 上下左右 : MonoBehaviour {

	public float スピード = 10;

	
	void Start()
	{
		rigidbody.useGravity = false;
	}

	void Update () 
	{
		float y = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Horizontal");

		Vector3 velocity = rigidbody.velocity;
		velocity.x = x * スピード;
		velocity.y = y * スピード;
		rigidbody.velocity = velocity;
	}
}
