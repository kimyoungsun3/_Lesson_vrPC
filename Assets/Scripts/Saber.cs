using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour {
	public LayerMask mask;
	private Vector3 previousPos;
	private Quaternion previousRot;

	void Update () {
		RaycastHit _hit;
		if (Physics.Raycast(transform.position, transform.forward, out _hit, 1, mask))
		{
			Vector3 _dragDir = transform.position - previousPos;
			if (Vector3.Angle(_dragDir, _hit.transform.up) > 130f
				|| Vector3.Angle(transform.rotation * Vector3.forward - previousRot * Vector3.forward, _hit.transform.up) > 130 )
			{
				Destroy(_hit.collider.gameObject);
			}
		}
		previousRot = transform.rotation;
		previousPos = transform.position;
	}
}
