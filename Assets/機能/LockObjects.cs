using UnityEngine;
using System.Collections;

public class LockObjects : MonoBehaviour {

	public bool 編集可能 = true;

	void OnValidate()
	{
		foreach( var obj in transform.GetComponentsInChildren<Transform>())
		{
			if( obj != transform)
			{
				if( 編集可能)
					obj.gameObject.hideFlags = HideFlags.None;
				else
					obj.gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
		}
	}
}
