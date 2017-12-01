using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
	public float maxVelocity = 7.0f;
	Rigidbody2D body;

	void Start () {
		body = GetComponent<Rigidbody2D> ();	
	}


	void Update () {
		
	}

	void FixedUpdate(){
		if (body.velocity.y > maxVelocity)
			body.velocity = new Vector2 (body.velocity.x, maxVelocity);
		else if(body.velocity.y < -maxVelocity)
			body.velocity = new Vector2 (body.velocity.x, -maxVelocity);
			
		//Debug.Log(body.velocity);
		if (Input.GetMouseButton (0)) {
			body.AddForce (new Vector2 (0, 11.0f), ForceMode2D.Force);
		}
		else if (Input.GetMouseButtonUp(0)) {
			body.velocity *= 0.60f;
		}

	}

	void OnTriggerEnter2D(Collider2D other) {


	}
}
