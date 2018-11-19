using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour {
	public GameObject PauseBtn,PlayBtn,CherryObj;
	public static bool playPressed,pausePressed,restartPressed = false;
   // public GameObject Menu;
    public void Start()
    {
//        Menu.SetActive(false);
       // GameOverobj.SetActive(false);
    }
    public void RestartGame()
    {
        
        SceneManager.LoadScene("MainScene");
        SpawnRush.avatarTouched = false;
		restartPressed = true;
		CherryObj.GetComponent<CherryFactory> ().enabled = true;

       
    }
    public void PauseGame()
    {
		Time.timeScale = 0;
		TextClignotant.playall = false;
		PlayBtn.SetActive(true);
		pausePressed = true;
		playPressed = false;
		PauseBtn.SetActive(false);
		CherryObj.GetComponent<CherryFactory> ().enabled = false;
		Debug.Log("paauuuuuuuse " + pausePressed);
        
    }
    public void PlayGame()
    {
		pausePressed = false;
		PauseBtn.SetActive(true);
		PlayBtn.SetActive(false);
		playPressed = true;
		Debug.Log("plaaaay " + playPressed);
		Time.timeScale = 1;
		CherryObj.GetComponent<CherryFactory> ().enabled = true;

    }

  
    public void HomePage()
    {

    }
}
