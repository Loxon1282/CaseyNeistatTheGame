using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject obstacle;
	public GameObject player;

	void Start () {
		InvokeRepeating ("Generate_Obstacle", 1, 4);
	}

	void Update () {
		
	}

	void Generate_Obstacle(){
		
		Instantiate(obstacle,new Vector2(player.transform.position.x+30.0f,Random.Range(-4.0f,4.0f)),Quaternion.Euler (0,0,0));
		obstacle.transform.localScale = new Vector3 (obstacle.transform.localScale.x, Random.Range (0.5f, 1.5f), obstacle.transform.localScale.z);
	}
}
