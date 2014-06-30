using UnityEngine;
using System.Collections;

[RequireComponent(typeof(前進))]
[RequireComponent(typeof(上下左右))]
[RequireComponent(typeof(Rigidbody))]
public class クラッシュ : MonoBehaviour {

	public GameObject 炎上エフェクト;

	private bool crashed = false;

	void Start()
	{
		if( 炎上エフェクト != null)
			炎上エフェクト.SetActive(false);
	}

	void OnCollisionEnter (Collision c)
	{
		if( crashed == false){

			rigidbody.AddExplosionForce(3000, c.contacts[0].point + transform.forward * -1f, 3) ;
			GetComponent<Rigidbody>().useGravity = true;
			GetComponent<前進>().enabled = false;
			GetComponent<上下左右>().enabled = false;
			if( 炎上エフェクト != null)
				炎上エフェクト.SetActive(true);
			crashed = true;
		}
	}

	void Update()
	{
		if( 炎上エフェクト != null)
			炎上エフェクト.transform.position = transform.position;
	}
}
