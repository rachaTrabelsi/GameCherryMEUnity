using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class TextClignotant : MonoBehaviour {
    public GameObject TapToPlaytext,Menu,pauseBtn,scoreObject,imgscore,txtscore;
    public GameObject spawnRocher, spawnRocher1,spawnRocher2 	;
    public static bool spawnRocherBool = false;
	public static bool playall = false;
    float timer,timer2 = 0.5f;
	// Use this for initialization
	void Start () {
        //TapToPlaytext = GetComponent<GameObject>();
        pauseBtn.SetActive(false);
        scoreObject.SetActive(false);
        imgscore.SetActive(false);
        txtscore.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("la valeur de spawnRocher " + TextClignotant.spawnRocherBool);
        if (Menu.activeSelf)
        {
          
           spawnRocher.GetComponent<RocherSpawnScript>().enabled = false;
            spawnRocher1.GetComponent<RocherSpawnScript>().enabled = false;
            spawnRocher2.GetComponent<RocherSpawnScript>().enabled = false;

        }
        if (timer > 0)
        {
            TapToPlaytext.SetActive(false);
            timer2 = 0.5f;
        }
          timer -= Time.deltaTime;
        if (timer < 0)
        {
            TapToPlaytext.SetActive(true);
            timer2 -= Time.deltaTime; 
            if (timer2< 0)
            {
               timer = 0.5f;
            }
        }
        if (Input.GetMouseButtonDown(0))
		{	playall = true;
            Menu.SetActive(false);
			scoreObject.SetActive(false);
            imgscore.SetActive(true);
            txtscore.SetActive(true);

            spawnRocherBool = true;
            spawnRocher.GetComponent<RocherSpawnScript>().enabled = true;

            spawnRocher1.GetComponent<RocherSpawnScript>().enabled = true;

            spawnRocher2.GetComponent<RocherSpawnScript>().enabled = true;
            Debug.Log("la valeur de spawnRocher fel mouse clicked " + spawnRocherBool);
		
            pauseBtn.SetActive(true);
        }
        Debug.Log("play fel text script "+ButtonsScript.playPressed);
        if (ButtonsScript.playPressed)
        {
            Debug.Log("play pressed ");
             Menu.SetActive(false);
            spawnRocherBool = true;
          
            spawnRocher.GetComponent<RocherSpawnScript>().enabled = true;

            spawnRocher1.GetComponent<RocherSpawnScript>().enabled = true;

            spawnRocher2.GetComponent<RocherSpawnScript>().enabled = true;
            Debug.Log("la valeur de spawnRocher fel mouse clicked " + spawnRocherBool);
          
        }
        Debug.Log("pause fel text script " + ButtonsScript.pausePressed);

        if (ButtonsScript.pausePressed)
        {
            Debug.Log("pause pressed");
            spawnRocherBool = false;
       
            spawnRocher.GetComponent<RocherSpawnScript>().enabled = false;

            spawnRocher1.GetComponent<RocherSpawnScript>().enabled = false;

            spawnRocher2.GetComponent<RocherSpawnScript>().enabled = false;
            Debug.Log("la valeur de spawnRocher fel mouse clicked " + spawnRocherBool);

        }
    }
}
