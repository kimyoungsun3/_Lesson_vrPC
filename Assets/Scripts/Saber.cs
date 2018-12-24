using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour {
	public LayerMask mask;
	private Vector3 previousPos;

	void Update () {
		RaycastHit _hit;
		if (Physics.Raycast(transform.position, transform.forward, out _hit, 1, mask))
		{
			Vector3 _dragDir = transform.position - previousPos;
			if (Vector3.Angle(_dragDir, _hit.transform.up) > 130f)
			{
				Destroy(_hit.collider.gameObject);
			}
		}

		previousPos = transform.position;
	}
}
