using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CherryFactory : MonoBehaviour {

	public GameObject cherry;

	public float spawnWait;
	public float CherryWait;
	public float CherryspawnWait;
	public float startWait;
	public int hazardCount;

	public GameObject[] gameobjects;
	public Vector2 spawnPosition;
	public Vector2 spawnValuesCherry;
	public static int  scoreCherry;

	void Start () {
	StartCoroutine(SpawnCherry());
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if (SpawnRush.avatarTouched == false) {
			for (int i = 0; i < hazardCount; i++) {
				spawnPosition = new Vector2 (spawnValuesCherry.x + Random.Range (-3f, 3f), spawnValuesCherry.y);
				//spawnPosition = new Vector2 (spawnValuesCherry.x + Random.Range (-10f, 10f) ,Random.Range (-7.5f, -7.4f) );

				Quaternion spawnRotation = Quaternion.identity;
				this.cherry = (GameObject)Instantiate (cherry, spawnPosition, spawnRotation);
				if (DestroyCherry.cherryisGrounded || DestroyCherry.cherryisEaten) {
					Debug.Log ("ena cheryy  min factory bech noumt  ground "); 
					Destroy (this.cherry, 1f);
				}
			}
		}*/
	
	}
	IEnumerator SpawnCherry ()
	{
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < hazardCount; i++) {
			yield return new WaitForSeconds (CherryspawnWait);
			spawnPosition = new Vector2 (spawnValuesCherry.x + Random.Range (-3f, 3f) , spawnValuesCherry.y  );
			//spawnPosition = new Vector2 (spawnValuesCherry.x + Random.Range (-10f, 10f) ,Random.Range (-7.5f, -7.4f) );

			Quaternion spawnRotation = Quaternion.identity;
				cherry = (GameObject) Instantiate (cherry, spawnPosition, spawnRotation);
			if( DestroyCherry.cherryisGrounded ||DestroyCherry.cherryisEaten) {
				Debug.Log ("ena cheryy  min factory bech noumt  ground "); 

			
			}
			if( SpawnRush.avatarTouched) {
				Debug.Log ("ena cheryy  min factory bech noumt  ground "); 
				gameobjects = GameObject.FindGameObjectsWithTag("cherrybonus");

				for (i = 0; i < gameobjects.Length-1; i++)
				{
					Destroy(gameobjects[i]);
				}

			}
			yield return new WaitForSeconds (CherryspawnWait);

		}

	
		yield return new WaitForSeconds (CherryWait);
	}



}
