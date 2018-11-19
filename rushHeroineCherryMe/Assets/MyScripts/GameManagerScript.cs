using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
	public GameObject scroll,scroll1 , cherry ,player , pausebtn , rush1 , rush2, rush3, scoreObject;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ButtonsScript.pausePressed) {
			scroll.GetComponent<SkyScrollScript> ().enabled = false;
			scroll1.GetComponent<SkyScrollScript> ().enabled = false;
			player.GetComponent<PlayerController> ().enabled = false;
			cherry.GetComponent<CherryFactory> ().enabled = false;
			rush1.GetComponent<RocherSpawnScript> ().enabled = false;
			rush2.GetComponent<RocherSpawnScript> ().enabled = false;
			rush3.GetComponent<RocherSpawnScript> ().enabled = false;

		}
		if (SpawnRush.avatarTouched)
		{
			//scoreObject.SetActive (false);
				scroll.GetComponent<SkyScrollScript> ().enabled = false;
				scroll1.GetComponent<SkyScrollScript> ().enabled = false;
				player.GetComponent<PlayerController> ().enabled = false;
				cherry.GetComponent<CherryFactory> ().enabled = false;
				pausebtn.SetActive (false);
			rush1.GetComponent<RocherSpawnScript> ().enabled = false;
			rush2.GetComponent<RocherSpawnScript> ().enabled = false;
			rush3.GetComponent<RocherSpawnScript> ().enabled = false;

		}

	}
}
