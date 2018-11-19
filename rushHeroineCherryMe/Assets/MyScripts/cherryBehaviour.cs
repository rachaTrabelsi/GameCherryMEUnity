using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cherryBehaviour : MonoBehaviour {
	public static int  scoreCherry;
	public Text ceriseCountertext;
	// Use this for initialization
	void Start () {
		scoreCherry = 0;
		ceriseCountertext.text = scoreCherry.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag.Equals ("ground")) {
			Destroy (this);
		}

		if (col.gameObject.tag.Equals("Player"))
		{
			scoreCherry += 1;

			ceriseCountertext.text = scoreCherry.ToString();
			Debug.Log (scoreCherry);
			Destroy (this);


		}

	}

}
