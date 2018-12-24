using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] cubes;
	public Transform[] points;
	public float beat = (60f/105) * 2f;
	private float time;


	void Update () {
		if(time > beat)
		{
			GameObject _prefab		= cubes[Random.Range(0, cubes.Length)];
			Transform _spawnPoint	= points[Random.Range(0, points.Length)];

			GameObject _bit = Instantiate(_prefab, _spawnPoint.position, _spawnPoint.rotation);
			time -= beat;
		}
		time += Time.deltaTime;

	}
}
