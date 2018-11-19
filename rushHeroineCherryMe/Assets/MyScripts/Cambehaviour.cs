using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambehaviour : MonoBehaviour {

	public Transform player;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(new Vector2(player.position.x+1.5f,player.position.y));
	}
}
