using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerScript : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void MoveLeft(){
		player.GetComponent<Rigidbody2D> ().velocity = Vector2.left*2;
	}
	public void MoveRight(){
		player.GetComponent<Rigidbody2D> ().velocity = Vector2.right*2;
	}
}
