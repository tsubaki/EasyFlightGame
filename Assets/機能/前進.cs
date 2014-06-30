using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class 前進 : MonoBehaviour {

	[Range(30, 50)]
	public float スピード = 30;

	void Start()
	{
		rigidbody.useGravity = false;
	}

	void Update () 
	{
		transform.position += transform.forward * Time.deltaTime * スピード;
	}
}
