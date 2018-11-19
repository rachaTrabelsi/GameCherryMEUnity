using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCherry : MonoBehaviour {
	public  static bool cherryisGrounded ;
	public static bool cherryisEaten ;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag.Equals ("ground")) {
			cherryisGrounded = true;
			gameObject.SetActive (false);
			Debug.Log ("ena cheryy  ground maaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasssssssssssssssiiiiiiiiiit ground "); 
		//	Destroy (gameObject);

		}

		if (coll.gameObject.tag.Equals ("Player")) {
			Debug.Log ("ena cheryy maaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasssssssssssssssiiiiiiiiiit player"); 
		//	Destroy (gameObject);
			cherryisEaten = true;
		}


	}



}
