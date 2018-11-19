using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScrollScript : MonoBehaviour {
	private Transform SkyTf ;
	public GameObject NewSky;
	private bool next = false;
	// Use this for initialization
	void Start () {
		SkyTf = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		SkyTf.Translate (new Vector2(-0.005f,0));
		if (SkyTf.position.x < -17f && !next) {
			Instantiate (NewSky , new Vector2 (20f,-5.54f), new Quaternion());
			next = true;
		}
			
		if (SkyTf.position.x < -20f) {
			Destroy (this.gameObject);
		}
	}
}
