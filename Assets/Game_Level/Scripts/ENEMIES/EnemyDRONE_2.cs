using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDRONE_2 : MonoBehaviour {

	Vector2 startPos;
	public float droneSpeed = 1.0f;

	void Start(){
		startPos = transform.position;
	}

	void Update () {
		transform.position = new Vector2(transform.position.x,Mathf.Sin(Time.deltaTime*20.0f)/20+startPos.y)+Vector2.left*droneSpeed;
	}

}
