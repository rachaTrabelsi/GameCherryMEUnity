using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocherSpawnScript : MonoBehaviour
{
    public static int score = 0;
    public Vector2 spawnPosition;

    public GameObject hazard, imgScore,scoreObject , cherryFactory  ;

    public Vector2 spawnValues;

    public int hazardCount;
    public Text scoreText, BestScore, ScoreTextNumber;
    public float spawnWait;
	public bool cherryinstantiate = false;
	public float startWait;
    public float waveWait;

    public GameObject[] gameobjects;
  
    void Start()
    {
		//hazard.SetActive (true);

	
        StartCoroutine(SpawnWaves());
	
        scoreObject.SetActive(false);
    }

 
    void Update()
    {
        // scoreText.GetComponent<GUIText>().text = "fdf";
		if (SpawnRush.groundTouched == true && !SpawnRush.avatarTouched)
		{ 
            Debug.Log("yyyyyyyyyyyyyyyyyy");
           	//imgScore.SetActive(true);

            SpawnRush.groundTouched = false;
            score++;
         
            Debug.Log("score " + score);
        //   scoreText.gameObject.SetActive(true);
           scoreText.text = score.ToString(); ;
        //    scoreText.transform.position = new Vector2(SpawnRush.posrush.x, -8);
            ScoreTextNumber.text = score.ToString();
            Debug.Log("Scoreeeee "+score);
            Debug.Log("Best Scooore "+ PlayerPrefs.GetInt("BestScore").ToString());
        }
        if (score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            BestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
            Debug.Log("Scoreeeee > best Score" + score);
            Debug.Log("Best Scooore < score " + PlayerPrefs.GetInt("BestScore").ToString());
        }
        else
        {
           BestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
        }
        // scoreText.text = "fdf";
        if (SpawnRush.avatarTouched)
        {
            imgScore.SetActive(true);
            gameobjects = GameObject.FindGameObjectsWithTag("rocher1");
            scoreObject.SetActive(false);
            for (var i = 0; i < gameobjects.Length; i++)
                Destroy(gameobjects[i]);
            score = 0;

			cherryFactory.GetComponent<CherryFactory> ().enabled = false;


        }
       
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
            for (int i = 0; i < hazardCount; i++)
            {
            if (!SpawnRush.avatarTouched)
            {
                yield return new WaitForSeconds(spawnWait);
                spawnPosition = new Vector2(spawnValues.x, spawnValues.y * -5f);
                Quaternion spawnRotation = Quaternion.identity;
                hazard = Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
       
            }
        
        yield return new WaitForSeconds(waveWait);
    }


  
    }



