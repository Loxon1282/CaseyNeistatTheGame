using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDRONE : MonoBehaviour {

	public float droneSpeed = 1.0f;


	void Update () {
		transform.position += Vector3.left * droneSpeed;
	}

}
