using UnityEngine;
using System.Collections;

public class おっかけカメラ : MonoBehaviour {

	public Transform ターゲット;

	private Vector3 firstDiff;

	void Start () 
	{
		firstDiff = transform.position - ターゲット.position;
	}
	
	void LateUpdate () 
	{
		Vector3 pos = transform.position;
		pos.z = ターゲット.position.z + firstDiff.z;
		pos = Vector3.Lerp(pos, ターゲット.position + firstDiff, 0.1f);

		transform.position = pos;
	}
}
