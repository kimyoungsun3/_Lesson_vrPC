using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRotate : MonoBehaviour {
	[SerializeField] float startAngle;
	[SerializeField] float speed;
	private void Start()
	{
		transform.rotation = transform.rotation * Quaternion.Euler(Vector3.forward * startAngle);
	}

	void Update () {
		transform.Rotate(Vector3.forward * speed * Time.deltaTime);	
	}
}
