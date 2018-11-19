using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
	public AudioSource background , heroDie, eatCherry, protection;

	// Use this for initialization
	void Start () {
		background.enabled= true;
		heroDie.enabled= false;
		eatCherry.enabled= false;
		protection.enabled= false;
	}
	
	// Update is called once per frame
	void Update () {
		if (DestroyCherry.cherryisEaten){
			//background.volume -= 0.1f;
			eatCherry.enabled= true;
		}
		if( SpawnRush.avatarTouched) {
			//background.volume -= 0.1f;
			heroDie.enabled= true;
		}
		if( PlayerController.isProtected) {
			//background.volume -= 0.1f;
			protection.enabled= true;
		}
		
	}
}
